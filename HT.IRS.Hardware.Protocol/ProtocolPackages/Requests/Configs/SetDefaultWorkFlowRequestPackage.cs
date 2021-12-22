using HT.IRS.Hardware.Protocol.Data.Requests.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class SetDefaultWorkFlowRequestPackage:RequestPackageBase
    {
        public SetDefaultWorkFlowRequestPackage(string data) : base(APIs.Configs.SetDefaultWorkflow)
        {
            Data = data;
        }

        public SetDefaultWorkFlowRequestPackage(SetDefaultWorkflowRequestData data):base(APIs.Configs.SetDefaultWorkflow)
        {
            Data = Serialize(data);
        }
    }
}
