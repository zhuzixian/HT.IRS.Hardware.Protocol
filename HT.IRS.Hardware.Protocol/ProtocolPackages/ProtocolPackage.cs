using System;
using System.Collections.Generic;
using System.Linq;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages
{
    public class ProtocolPackage
    {
        /// <summary>
        /// 协议版本
        /// </summary>
        public byte ProtocolVersion { get; set; }

        /// <summary>
        /// 上行？
        /// </summary>
        public bool IsRequestMessage { get; set; }

        /// <summary>
        /// 流水码
        /// </summary>
        public ushort SequenceNo { get; set; }

        /// <summary>
        /// 时间戳
        /// </summary>
        public DateTime Timestamp { get; set; }

        /// <summary>
        /// 请求类型
        /// </summary>
        public ushort Api { get; set; }


        /// <summary>
        /// 正文
        /// </summary>
        public string Data { get; set; }

        public ProtocolPackage()
        {
        }

        public ProtocolPackage(byte protocolVersion,
            bool isRequestMessage,
            ushort sequenceNo,
            ushort api,
            string data)
        {
            ProtocolVersion = protocolVersion;
            IsRequestMessage = isRequestMessage;
            SequenceNo = sequenceNo;
            Api = api;
            Data = data;
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
            var timestampBytes = BitConverter.GetBytes(utcTimestamp).Reverse();
            results.AddRange(timestampBytes);

            // 序列号
            var sequenceNoBytes = BitConverter.GetBytes(sequenceNo).Reverse();
            results.AddRange(sequenceNoBytes);

            // 保留字节
            results.AddRange(new byte[8]);

            // 请求类型
            var apiTypeBytes = BitConverter.GetBytes(api).Reverse().ToArray();
            results.AddRange(apiTypeBytes);

            var dataBytes = string.IsNullOrEmpty(data)
                ? null
                : System.Text.Encoding.UTF8.GetBytes(data);

            // 正文长度
            var dataLenBytes = dataBytes == null
                ? BitConverter.GetBytes((uint)0).Reverse()
                : BitConverter.GetBytes((uint)dataBytes.Length).Reverse();
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
        /// <param name="data">数据</param>
        /// <param name="startIndex">起始位置</param>
        /// <param name="length">长度</param>
        /// <param name="message">结果</param>
        /// <returns></returns>
        public static bool TryParse(byte[] data, int startIndex, int length, out ProtocolPackage package)
        {
            package = new ProtocolPackage();
            var protocolVersionIndex = sizeof(byte);
            var isRequestMessageIndex = protocolVersionIndex + sizeof(byte);
            var timestampIndex = isRequestMessageIndex + sizeof(byte);
            var sequenceNoIndex = timestampIndex + sizeof(ulong);
            var apiIndex= sequenceNoIndex + sizeof(ushort) + sizeof(byte) * 8;
            var dataLengthIndex = apiIndex + sizeof(ushort);
            var dataTypeIndex = dataLengthIndex + sizeof(uint);
            var dataStartIndex = dataTypeIndex + sizeof(byte);

            var minLength = dataStartIndex + sizeof(byte) * 2 + sizeof(byte);
            if (data == null || data.Length < minLength)
            {
                return false;
            }

            if (data.First() != Header || data.Last() != End)
            {
                return false;
            }

            var bytes = data.Skip(startIndex).Take(length).ToArray();
            var sourceCrc = bytes.Skip(bytes.Length - 3).Take(2).ToArray();
            var crc = CrcCalculator.CalculateCrc(bytes.Skip(1).Take(bytes.Length - 4).ToArray());
            for (var i = 0; i < sourceCrc.Length; i++)
            {
                if (crc[i] != sourceCrc[i])
                {
                    return false;
                }
            }

            var dataLengthBytes = bytes.Skip(dataLengthIndex).Take(sizeof(uint)).Reverse().ToArray();
            var dataLength = (int)BitConverter.ToUInt32(dataLengthBytes, 0);
            if (bytes.Length != dataStartIndex + dataLength + sizeof(byte) * 2 + sizeof(byte))
            {
                return false;
            }

            package.ProtocolVersion = bytes[protocolVersionIndex];
            package.IsRequestMessage = bytes[isRequestMessageIndex] == 0x00;
            
            var timestampBytes = data.Skip(timestampIndex).Take(sizeof(ulong))
                .Reverse().ToArray();
            var timestamp = (long)BitConverter.ToUInt64(timestampBytes, 0);
            var baseDateTime = new DateTime(1970, 1, 1);
            package.Timestamp = baseDateTime.AddMilliseconds(timestamp).ToLocalTime();

            var sequenceNoBytes = bytes.Skip(sequenceNoIndex).Take(sizeof(ushort))
                .Reverse().ToArray();
            package.SequenceNo = BitConverter.ToUInt16(sequenceNoBytes, 0);

            var apiBytes = bytes.Skip(apiIndex).Take(sizeof(ushort))
                .Reverse().ToArray();
            package.Api = BitConverter.ToUInt16(apiBytes, 0);
        
            var dataBytes = bytes.Skip(dataStartIndex).Take(dataLength).ToArray();
            package.Data = System.Text.Encoding.UTF8.GetString(dataBytes);

            return true;
        }

        public static byte Header => 0XCE;
        public static byte End => 0xFE;
    }
}
