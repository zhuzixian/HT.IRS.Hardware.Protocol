namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class EmergencyInfo:RequestPackageBase
    {
        public EmergencyInfo()
        {
            Api = Protocol.Api.StatusEmergency;
        }
    }
}
