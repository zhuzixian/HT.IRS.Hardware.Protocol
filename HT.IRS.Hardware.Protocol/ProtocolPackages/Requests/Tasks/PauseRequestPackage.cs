using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class PauseRequestPackage:TaskRequestPackageBase
    {
        public PauseRequestPackage(string data) : base(APIs.Tasks.Pause, data)
        {
        }

        public PauseRequestPackage(PauseRequestData data) : base(APIs.Tasks.Pause)
        {
            Data = Serialize(data);
        }
    }
}
