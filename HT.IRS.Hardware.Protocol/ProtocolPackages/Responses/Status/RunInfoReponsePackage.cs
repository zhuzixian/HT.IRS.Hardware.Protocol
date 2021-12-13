namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class RunInfoResponsePackage: ResponsePackageBase
    {
        public RunInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetRunInfos;
        }
    }
}
