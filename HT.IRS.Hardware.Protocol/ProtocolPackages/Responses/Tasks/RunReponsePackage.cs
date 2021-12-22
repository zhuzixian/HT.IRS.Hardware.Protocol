using HT.IRS.Hardware.Protocol.Data.Responses.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class RunResponsePackage:ResponsePackageBase<RunResponseData>
    {
        public RunResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Run, sequenceNo, data) 
        {
        }

        public RunResponsePackage(ushort sequenceNo, RunResponseData data) 
            : base(APIs.Tasks.Run, sequenceNo, data)
        {
        }
    }
}
