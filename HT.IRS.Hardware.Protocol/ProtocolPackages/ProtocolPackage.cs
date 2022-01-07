using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages
{
    public class ProtocolPackage
    {
        public override string ToString()
        {
            var stringBuild = new StringBuilder();
            stringBuild.AppendLine($"ProtocolVersion: {ProtocolVersion}");
            stringBuild.AppendLine($"IsRequestMessage: { IsRequestMessage }");
            stringBuild.AppendLine($"SequenceNo: { SequenceNo }");
            stringBuild.AppendLine($"Timestamp: {Timestamp:yyyy-MM-dd HH:mm:ss.fff}");
            stringBuild.AppendLine($"Api: {Api}");
            stringBuild.AppendLine($"Data: {Environment.NewLine}{Data}");
            return stringBuild.ToString();
        }

        /// <summary>
        /// 协议版本
        /// </summary>
        public byte ProtocolVersion { get; protected set; }

        /// <summary>
        /// 上行？
        /// </summary>
        public bool IsRequestMessage { get; protected set; }

        /// <summary>
        /// 流水码
        /// </summary>
        public ushort SequenceNo { get; protected set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Timestamp { get; protected set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        public ushort Api { get; protected set; }


        /// <summary>
        /// 正文
        /// </summary>
        public string Data { get; protected set; }

        static ProtocolPackage()
        {
            Locker = new object();
        }

        public ProtocolPackage()
        {
            SequenceNo = GetNextSequenceNo();
            Timestamp = DateTime.Now;
        }

        public ProtocolPackage(
            bool isRequestMessage,
            ushort api,
            string data,
            ushort sequenceNo = ushort.MinValue,
            byte protocolVersion = 0x01,
            DateTime? timestamp =  null)
        {
            ProtocolVersion = protocolVersion;
            IsRequestMessage = isRequestMessage;
            SequenceNo = sequenceNo == ushort.MinValue ? GetNextSequenceNo() : sequenceNo;
            Api = api;
            Data = data;
            Timestamp = timestamp ?? DateTime.Now;
        }

        /// <summary>
        /// 获取发送的数据
        /// </summary>
        /// <returns></returns>
        public byte[] GetBytes()
        {
            return GetBytes(ProtocolVersion, IsRequestMessage, Timestamp, SequenceNo, Api, Data);
        }

        /// <summary>
        /// 获取发送的数据
        /// </summary>
        /// <param name="protocolVersion">协议主版本</param>
        /// <param name="isRequestMessage">上行</param>
        /// <param name="timestamp"></param>
        /// <param name="sequenceNo">流水码</param>
        /// <param name="api">请求类型</param>
        /// <param name="data">数据</param>
        /// <returns></returns>
        public static byte[] GetBytes(
            byte protocolVersion,
            bool isRequestMessage,
            DateTime timestamp,
            ushort sequenceNo,
            ushort api, 
            string data)
        {
            var results = new List<byte>
            {
                // 报文头
                Header,
                // 协议主版本
                protocolVersion,
                // 上下行
                isRequestMessage ? (byte)0x00 : (byte)0x01
            };

            // 时间戳
            var utcTimestamp = (ulong)(timestamp.ToUniversalTime() - new DateTime(1970, 1, 1, 0, 0, 0, 0))
                .TotalMilliseconds;
            var timestampBytes = BitConverter.GetBytes(utcTimestamp);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timestampBytes);
            }
            results.AddRange(timestampBytes);

            // 序列号
            var sequenceNoBytes = BitConverter.GetBytes(sequenceNo);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(sequenceNoBytes);
            }
            results.AddRange(sequenceNoBytes);

            // 保留字节
            results.AddRange(new byte[8]);

            // 请求类型
            var apiTypeBytes = BitConverter.GetBytes(api);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(apiTypeBytes);
            }
            results.AddRange(apiTypeBytes);

            var dataBytes = string.IsNullOrEmpty(data)
                ? null
                : Encoding.UTF8.GetBytes(data);

            // 正文长度
            var dataLenBytes = dataBytes == null
                ? BitConverter.GetBytes((uint)0)
                : BitConverter.GetBytes((uint)dataBytes.Length);
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(dataLenBytes);
            }
            results.AddRange(dataLenBytes);

            // 正文类型
            results.Add(0x00);

            // 正文
            if (dataBytes != null)
            {
                results.AddRange(dataBytes);
            }

            // 校验
            var crc = CrcCalculator.CalculateCrc(results.Skip(1).ToArray());
            results.AddRange(crc);

            // 报文尾
            results.Add(End);
            return results.ToArray();
        }

        /// <summary>
        /// 解析
        /// </summary>
        /// <param name="binary">数据</param>
        /// <param name="startIndex">起始位置</param>
        /// <param name="length">长度</param>
        /// <param name="package"></param>
        /// <returns></returns>
        public static bool TryParse(byte[] binary, int startIndex, int length, out ProtocolPackage package)
        {
            package = default;
            var protocolVersionIndex = sizeof(byte);
            var isRequestMessageIndex = protocolVersionIndex + sizeof(byte);
            var timestampIndex = isRequestMessageIndex + sizeof(byte);
            var sequenceNoIndex = timestampIndex + sizeof(ulong);
            var apiIndex= sequenceNoIndex + sizeof(ushort) + sizeof(byte) * 8;
            var dataLengthIndex = apiIndex + sizeof(ushort);
            var dataTypeIndex = dataLengthIndex + sizeof(uint);
            var dataStartIndex = dataTypeIndex + sizeof(byte);

            var minLength = dataStartIndex + sizeof(byte) * 2 + sizeof(byte);
            if (binary == null || binary.Length < minLength)
            {
                return false;
            }

            if (binary.First() != Header || binary.Last() != End)
            {
                return false;
            }

            var bytes = binary.Skip(startIndex).Take(length).ToArray();
            var sourceCrc = bytes.Skip(bytes.Length - 3).Take(2).ToArray();
            var crc = CrcCalculator.CalculateCrc(bytes.Skip(1).Take(bytes.Length - 4).ToArray());
            for (var i = 0; i < sourceCrc.Length; i++)
            {
                if (crc[i] != sourceCrc[i])
                {
                    return false;
                }
            }

            var dataLengthBytes = bytes.Skip(dataLengthIndex).Take(sizeof(uint)).ToArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(dataLengthBytes);
            }
            var dataLength = (int)BitConverter.ToUInt32(dataLengthBytes, 0);
            if (bytes.Length != dataStartIndex + dataLength + sizeof(byte) * 2 + sizeof(byte))
            {
                return false;
            }

            var protocolVersion = bytes[protocolVersionIndex];
            var isRequestMessage = bytes[isRequestMessageIndex] == 0x00;
            
            var timestampBytes = binary.Skip(timestampIndex).Take(sizeof(ulong)).ToArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(timestampBytes);
            }
            var timestamp = (long)BitConverter.ToUInt64(timestampBytes, 0);
            var baseDateTime = new DateTime(1970, 1, 1);
            package.Timestamp = baseDateTime.AddMilliseconds(timestamp).ToLocalTime();

            var sequenceNoBytes = bytes.Skip(sequenceNoIndex).Take(sizeof(ushort)).ToArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(sequenceNoBytes);
            }
            var sequenceNo = BitConverter.ToUInt16(sequenceNoBytes, 0);

            var apiBytes = bytes.Skip(apiIndex).Take(sizeof(ushort)).ToArray();
            if (BitConverter.IsLittleEndian)
            {
                Array.Reverse(apiBytes);
            }
            var api = BitConverter.ToUInt16(apiBytes, 0);
        
            var dataBytes = bytes.Skip(dataStartIndex).Take(dataLength).ToArray();
            var data = System.Text.Encoding.UTF8.GetString(dataBytes);

            package = new ProtocolPackage(isRequestMessage, api, data, sequenceNo, protocolVersion);
            return true;
        }

        public static byte Header => 0XCE;
        public static byte End => 0xFE;

        private static ushort _nextSequence = ushort.MinValue + 1;
        private static readonly object Locker;

        public static ushort GetNextSequenceNo()
        {
            lock(Locker)
            {
                return _nextSequence++;
            }
        }

        protected string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj, SerializerOptions);
        }

        public static JsonSerializerOptions SerializerOptions => new JsonSerializerOptions
        {
            PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            WriteIndented = true
        };
    }
}
