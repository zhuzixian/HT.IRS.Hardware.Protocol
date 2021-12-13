namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class IoInfoRequestPackage:RequestPackageBase
    {
        public IoInfoRequestPackage()
        {
            Api = APIs.Status.GetIoInfos;
        }
    }
}
