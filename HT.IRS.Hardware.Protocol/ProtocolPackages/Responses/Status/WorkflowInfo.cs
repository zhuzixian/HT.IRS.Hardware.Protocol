namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{ 
    public class WorkflowInfo:ResponsePackageBase
    {
        public WorkflowInfo(string data) : base(data)
        {
            Api = Protocol.Api.StatusWorkflow;
        }
    }
}
