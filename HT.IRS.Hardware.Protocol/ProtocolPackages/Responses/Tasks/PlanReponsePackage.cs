using HT.IRS.Hardware.Protocol.Data.Responses.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class PlanResponsePackage:ResponsePackageBase<PlanResponseData>
    {
        public PlanResponsePackage(ushort sequenceNo, string data):base(APIs.Tasks.Plan, sequenceNo, data) 
        {
        }

        public PlanResponsePackage(ushort sequenceNo, PlanResponseData data) : base(APIs.Tasks.Plan, sequenceNo, data)
        {
        }
    }
}
