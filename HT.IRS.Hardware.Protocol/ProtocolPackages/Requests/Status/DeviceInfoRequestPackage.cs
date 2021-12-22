namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class DeviceInfoRequestPackage:RequestPackageBase
    {
        public DeviceInfoRequestPackage():base(APIs.Status.GetDeviceInfos)
        {
        }
    }
}
