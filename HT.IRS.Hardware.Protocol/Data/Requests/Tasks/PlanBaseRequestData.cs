using System;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks
{
    public class PlanBaseRequestData:TaskRequestBaseRequestData
    {
        public virtual int Type { get; set; }
        public string WorkflowId { get; set; }
    }
}
