namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class Plan:TaskRequestPackageBase
    {
        public Plan(string data):base(data)
        {
            Api = Protocol.Api.TaskPlan;
        }
    }
}
