namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{ 
    public class WorkflowInfoResponsePackage:ResponsePackageBase
    {
        public WorkflowInfoResponsePackage(string data) : base(data)
        {
            Api = APIs.Status.GetDeviceInfos;
        }
    }
}
