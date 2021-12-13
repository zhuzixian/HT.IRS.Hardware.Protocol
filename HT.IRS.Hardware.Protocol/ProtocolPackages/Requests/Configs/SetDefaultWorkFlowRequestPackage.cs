namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class SetDefaultWorkFlowRequestPackage:RequestPackageBase
    {
        public SetDefaultWorkFlowRequestPackage(string data)
        {
            Data = data;
            Api = APIs.Configs.SetDefaultWorkflow;
        }
    }
}
