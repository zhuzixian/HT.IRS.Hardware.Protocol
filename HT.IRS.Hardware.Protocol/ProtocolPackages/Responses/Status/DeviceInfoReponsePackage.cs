namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class DeviceInfoResponsePackage: ResponsePackageBase
    {
        public DeviceInfoResponsePackage(string data):base(data)
        {
            Api = Protocol.APIs.Status.GetDeviceInfos;
        }
    }
}
