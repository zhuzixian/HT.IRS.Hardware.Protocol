namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class IoInfoRequestPackage:RequestPackageBase
    {
        public IoInfoRequestPackage():base(APIs.Status.GetIoInfos)
        {
        }
    }
}
