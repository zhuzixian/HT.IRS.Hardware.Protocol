using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class TroublesInfoResponsePackage : ResponsePackageBase<TroubleInfoResponseData>
    {
        public TroublesInfoResponsePackage(ushort sequenceNo, string data)
            :base(sequenceNo, APIs.Status.GetTroubleInfos, data)
        {
        }

        public TroublesInfoResponsePackage(ushort sequenceNo, TroubleInfoResponseData data) 
            : base(APIs.Status.GetTroubleInfos, sequenceNo, data) 
        {
        }
    }
}
