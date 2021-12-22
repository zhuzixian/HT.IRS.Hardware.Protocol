using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class IoInfoResponsePackage: ResponsePackageBase<IoInfoResponseData>
    {
        public IoInfoResponsePackage(ushort sequenceNo, string data)
            :base(sequenceNo, APIs.Status.GetIoInfos, data)
        {
        }

        public IoInfoResponsePackage(ushort sequenceNo, IoInfoResponseData data) 
            : base(APIs.Status.GetIoInfos, sequenceNo, data)
        {
        }
    }
}
