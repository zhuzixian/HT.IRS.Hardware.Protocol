namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class PlanRequestPackage:TaskRequestPackageBase
    {
        public PlanRequestPackage(string data):base(data)
        {
            Api = APIs.Tasks.Plan;
        }
    }
}
