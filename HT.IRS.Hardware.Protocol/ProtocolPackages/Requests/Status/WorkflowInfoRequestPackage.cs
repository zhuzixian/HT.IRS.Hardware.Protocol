namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class WorkflowInfoRequestPackage:RequestPackageBase
    {
        public WorkflowInfoRequestPackage():base(APIs.Status.GetWorkFlowInfos)
        {
        }
    }
}
