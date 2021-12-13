namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.AbUnits
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
        public bool IsReplaceATipsBox { get; set; }
        public bool IsReplaceBTipsBox { get; set; }
    }
}
