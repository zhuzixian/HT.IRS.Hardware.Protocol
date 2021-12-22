using HT.IRS.Hardware.Protocol.Data.Responses.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class PauseResponsePackage:ResponsePackageBase<PauseResponseData>
    {
        public PauseResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Pause, sequenceNo, data)
        {
        }

        public PauseResponsePackage(ushort sequenceNo, PauseResponseData data) : base(APIs.Tasks.Pause, sequenceNo, data)
        {
        }
    }
}
