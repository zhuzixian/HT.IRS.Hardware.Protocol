namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class Run:TaskRequestPackageBase
    {
        public Run(string data) : base(data)
        {
            Api = Protocol.Api.TaskRun;
        }
    }
}
