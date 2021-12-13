namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class EmergencyInfoResponsePackage: ResponsePackageBase
    {
        public EmergencyInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetEmergencyInfos;
        }
    }
}
