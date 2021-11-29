namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class WorkFlowInfo:ResponseBase
    {
        public WorkFlow[] WorkFlows { get; set; }
    }

    public class WorkFlow
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public int Type { get; set; }
        public string Description { get; set; }
    }
}
