namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class ExInfoRequestPackage:RequestPackageBase
    {
        public ExInfoRequestPackage()
        {
            Api = APIs.Status.GetExInfos;
        }
    }
}
