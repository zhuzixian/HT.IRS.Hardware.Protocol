namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class DeviceInfo:StatusResponsePackageBase
    {
        public DeviceInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusInfo;
        }
    }
}
