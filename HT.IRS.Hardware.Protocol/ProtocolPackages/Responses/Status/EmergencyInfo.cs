namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class EmergencyInfo: ResponsePackageBase
    {
        public EmergencyInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusEmergency;
        }
    }
}
