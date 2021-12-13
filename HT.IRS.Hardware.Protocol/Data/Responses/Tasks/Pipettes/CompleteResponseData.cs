using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes
{
    public class CompleteResponseData
    {
        public IEnumerable<PipettingProcedure> CompletedProcedures { get; set; }
    }
}
