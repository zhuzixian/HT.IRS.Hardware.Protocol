namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class RunInfo:StatusResponsePackageBase
    {
        public RunInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusRun;
        }
    }
}
