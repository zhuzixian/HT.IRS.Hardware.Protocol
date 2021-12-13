namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.DUnits
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public Param Param { get; set; }
    }

    public class Param : PipettePlanParam
    {
        public bool IsReplaceTipsBox { get; set; }
    }
}
