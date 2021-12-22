namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class RunInfoRequestPackage:RequestPackageBase
    {
        public RunInfoRequestPackage(): base(APIs.Status.GetRunInfos)
        {
        }
    }
}
