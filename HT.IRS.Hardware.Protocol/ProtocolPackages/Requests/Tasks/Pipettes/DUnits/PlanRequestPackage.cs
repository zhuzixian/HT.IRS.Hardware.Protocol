namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks.Pipettes.DUnits
{
    public class PlanRequestPackage:TaskRequestPackageBase
    {
        public PlanRequestPackage(string data):base(APIs.Tasks.Plan, data)
        {
        }

        public PlanRequestPackage(Data.Requests.Tasks.Pipettes.DUnits.PlanRequestData data)
            : base(APIs.Tasks.Plan)
        {
            Data = Serialize(data);
        }
    }
}
