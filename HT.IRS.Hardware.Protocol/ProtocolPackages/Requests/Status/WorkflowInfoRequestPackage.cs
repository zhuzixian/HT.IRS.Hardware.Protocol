namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class WorkflowInfoRequestPackage:RequestPackageBase
    {
        public WorkflowInfoRequestPackage()
        {
            Api = APIs.Status.GetWorkflowInfos;
        }
    }
}
