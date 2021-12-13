namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class PlanResponsePackage:ResponsePackageBase
    {
        public PlanResponsePackage(string data):base(data)
        {
            Data = data;
            Api = Protocol.APIs.Tasks.Plan;
        }
    }
}
