using HT.IRS.Hardware.Protocol.Data.Responses;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses
{
    public class ResponsePackageBase<T>:ProtocolPackage
        where T : ResponseDataBase
    {
        public ResponsePackageBase(ushort api, 
           ushort sequenceNo, string data)
        {
            Api = api;
            SequenceNo = sequenceNo;
            Data = data;
            IsRequestMessage = false;
        }

        public ResponsePackageBase(ushort api, ushort sequenceNo, T data)
        {
            Api = api;
            SequenceNo = sequenceNo;
            Data = Serialize(data);
            IsRequestMessage = false;
        }
    }
}
