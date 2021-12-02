namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class Run:ResponsePackageBase
    {
        public Run(string data) : base(data)
        {
            Api = Protocol.Api.TaskRun;
        }
    }
}
