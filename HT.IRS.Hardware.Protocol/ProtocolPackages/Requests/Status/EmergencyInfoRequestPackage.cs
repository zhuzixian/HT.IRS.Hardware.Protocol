namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class EmergencyInfoRequestPackage:RequestPackageBase
    {
        public EmergencyInfoRequestPackage()
        {
            Api = Protocol.APIs.Status.GetEmergencyInfos;
        }
    }
}
