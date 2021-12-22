using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class EmergencyInfoResponsePackage: ResponsePackageBase<EmergencyInfoResponseData>
    {
        public EmergencyInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetEmergencyInfos, sequenceNo, data)
        {
        }

        public EmergencyInfoResponsePackage(ushort sequenceNo, EmergencyInfoResponseData data) 
            : base(APIs.Status.GetEmergencyInfos, sequenceNo, data)
        {
        }
    }
}
