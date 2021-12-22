using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class TaskInfoResponsePackage: ResponsePackageBase<TaskInfoResponseData>
    {
        public TaskInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetTaskInfos, sequenceNo, data)
        {
        }

        public TaskInfoResponsePackage(ushort sequenceNo, TaskInfoResponseData data) 
            : base(APIs.Status.GetTaskInfos, sequenceNo, data)
        {
        }
    }
}
