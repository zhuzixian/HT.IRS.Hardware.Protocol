namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks.Robots.Navigate
{
    public class PlanRequestPackage:TaskRequestPackageBase
    {
        public PlanRequestPackage(string data):base(APIs.Tasks.Plan, data)
        {
        }

        public PlanRequestPackage(Data.Requests.Tasks.Robots.Navigate.PlanRequestData data)
            : base(APIs.Tasks.Plan)
        {
            Data = Serialize(data);
        }
    }
}
