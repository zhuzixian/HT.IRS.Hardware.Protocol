namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks.Robots.Handle
{
    public class PlanRequestPackage:TaskRequestPackageBase
    {
        public PlanRequestPackage(string data):base(APIs.Tasks.Plan, data)
        {
        }

        public PlanRequestPackage(Data.Requests.Tasks.Robots.Handle.PlanRequestData data)
            : base(APIs.Tasks.Plan)
        {
            Data = Serialize(data);
        }
    }
}
