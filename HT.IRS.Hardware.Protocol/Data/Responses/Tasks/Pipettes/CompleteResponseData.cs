using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes
{
    public class CompleteResponseData:Tasks.CompleteResponseData
    {
        public IEnumerable<PipettingProcedureCompleteData> CompletedProcedures { get; set; }
    }
}
