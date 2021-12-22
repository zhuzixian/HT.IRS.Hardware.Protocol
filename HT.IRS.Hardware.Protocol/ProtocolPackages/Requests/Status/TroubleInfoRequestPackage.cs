namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class TroubleInfoRequestPackage:RequestPackageBase
    {
        public TroubleInfoRequestPackage():base(APIs.Status.GetTroubleInfos)
        {
        }
    }
}
