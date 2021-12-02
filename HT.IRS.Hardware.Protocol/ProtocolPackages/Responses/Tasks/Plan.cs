namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class Plan:ResponsePackageBase
    {
        public Plan(string data):base(data)
        {
            Data = data;
            Api = Protocol.Api.TaskPlan;
        }
    }
}
