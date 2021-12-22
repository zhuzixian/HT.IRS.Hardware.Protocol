using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class RunRequestPackage:TaskRequestPackageBase
    {
        public RunRequestPackage(string data) : base( APIs.Tasks.Run, data)
        {
        }

        public RunRequestPackage(RunRequestData data) : base(APIs.Tasks.Run)
        {
            Data = Serialize(data);
        }
    }
}
