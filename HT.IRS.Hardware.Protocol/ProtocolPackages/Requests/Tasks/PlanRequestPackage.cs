using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class PlanRequestPackage<T>:TaskRequestPackageBase
        where T: PlanBaseRequestData
    {
        public PlanRequestPackage(string data):base(APIs.Tasks.Plan, data)
        {
        }

        public PlanRequestPackage(T data) : base(APIs.Tasks.Plan)
        {
            Data = Serialize(data);
        }
    }
}
