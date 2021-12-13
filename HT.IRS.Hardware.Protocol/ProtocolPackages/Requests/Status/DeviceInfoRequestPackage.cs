namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class DeviceInfoRequestPackage:RequestPackageBase
    {
        public DeviceInfoRequestPackage()
        {
            Api = Protocol.APIs.Status.GetDeviceInfos;
        }
    }
}
