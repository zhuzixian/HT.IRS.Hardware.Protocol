namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.CUnits
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
        public bool IsReplaceTipsBox { get; set; }

        public SpecifyPipetting[] SpecifyPipettings { get; set; }
    }

    public class SpecifyPipetting
    {
        public string CodeRegular { get; set; }
        public Location Target { get; set; }
    }
}
