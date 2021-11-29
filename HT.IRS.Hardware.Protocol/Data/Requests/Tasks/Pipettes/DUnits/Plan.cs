using HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.DUnits
{
    public class Plan: PlanBase
    {
        public Plan()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Carry;

        public Param Param { get; set; }
    }

    public class Param : PlanParam
    {
        public bool IsReplaceTipsBox { get; set; }
    }
}
