namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class RunInfo: ResponsePackageBase
    {
        public RunInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusRun;
        }
    }
}
