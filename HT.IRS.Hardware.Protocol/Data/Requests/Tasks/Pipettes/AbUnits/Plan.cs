namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.AbUnits
{
    public class Plan: PlanBase
    {
        public Plan()
        {
            Param = new Param();
        }

        public Param Param { get; set; }
    }

    public class Param : PlanBase
    {
        public bool IsReplaceATipsBox { get; set; }
        public bool IsReplaceBTipsBox { get; set; }
    }
}
