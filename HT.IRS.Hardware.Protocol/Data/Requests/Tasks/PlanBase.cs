using System;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks
{
    public class PlanBase:TaskRequestBase
    {
        public virtual int Type { get; set; }
        public Guid WorkflowId { get; set; }
    }
}
