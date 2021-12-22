namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks.Robots.PickPlace
{
    public class PlanRequestPackage:TaskRequestPackageBase
    {
        public PlanRequestPackage(string data):base(APIs.Tasks.Plan, data)
        {
        }

        public PlanRequestPackage(Data.Requests.Tasks.Robots.PickPlace.PlanRequestData data)
            : base(APIs.Tasks.Plan)
        {
            Data = Serialize(data);
        }
    }
}
