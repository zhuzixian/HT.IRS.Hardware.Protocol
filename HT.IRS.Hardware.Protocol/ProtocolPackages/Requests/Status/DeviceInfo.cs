namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class DeviceInfo:RequestPackageBase
    {
        public DeviceInfo()
        {
            Api = Protocol.Api.StatusInfo;
        }
    }
}
