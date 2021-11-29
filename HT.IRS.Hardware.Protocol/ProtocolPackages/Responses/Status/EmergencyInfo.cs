namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class EmergencyInfo:StatusResponsePackageBase
    {
        public EmergencyInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusEmergency;
        }
    }
}
