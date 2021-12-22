namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class ExInfoRequestPackage:RequestPackageBase
    {
        public ExInfoRequestPackage():base(APIs.Status.GetExInfos)
        {
        }
    }
}
