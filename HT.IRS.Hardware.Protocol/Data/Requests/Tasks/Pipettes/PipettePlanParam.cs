using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes
{
    public class PipettePlanParam
    {
        public bool IsReplaceDiscardTipsBox { get; set; }
        public IEnumerable<PipettingProcedure> PipettingProcedures { get; set; }
    }
}
