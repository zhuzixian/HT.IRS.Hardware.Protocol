namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class RunInfoRequestPackage:RequestPackageBase
    {
        public RunInfoRequestPackage()
        {
            Api = APIs.Status.GetRunInfos;
        }
    }
}
