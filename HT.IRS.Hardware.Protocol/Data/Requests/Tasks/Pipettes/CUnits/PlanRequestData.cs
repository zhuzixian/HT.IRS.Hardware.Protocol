using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes.CUnits
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

        public int SampleTray { get; set; }

        public IEnumerable<SpecifyProcedure> SpecifySpecifyProcedures { get; set; }
    }

    public class SpecifyProcedure
    {
        public string CodeRegular { get; set; }
        public Location Target { get; set; }
    }
}
