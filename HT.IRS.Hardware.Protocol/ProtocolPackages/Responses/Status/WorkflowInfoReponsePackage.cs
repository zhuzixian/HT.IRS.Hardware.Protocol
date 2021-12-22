using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{ 
    public class WorkflowInfoResponsePackage:ResponsePackageBase<WorkFlowInfoResponseData>
    {
        public WorkflowInfoResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Status.GetWorkFlowInfos, sequenceNo, data)
        {
        }

        public WorkflowInfoResponsePackage(ushort sequenceNo, WorkFlowInfoResponseData data) 
            : base(APIs.Status.GetWorkFlowInfos, sequenceNo, data)
        {
        }
    }
}
