using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ExInfoResponsePackage: ResponsePackageBase<ExInfoResponseData>
    {
        public ExInfoResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Status.GetExInfos, sequenceNo, data)
        {
        }

        public ExInfoResponsePackage(ushort sequenceNo, ExInfoResponseData data) 
            : base(APIs.Status.GetExInfos, sequenceNo, data)
        {
        }
    }
}
