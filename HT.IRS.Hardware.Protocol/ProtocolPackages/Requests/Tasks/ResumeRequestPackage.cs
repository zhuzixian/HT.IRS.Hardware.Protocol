using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class ResumeRequestPackage:TaskRequestPackageBase
    {
        public ResumeRequestPackage(string data) : base(APIs.Tasks.Resume, data)
        {
        }

        public ResumeRequestPackage(ResumeRequestData data) : base(APIs.Tasks.Resume)
        {
            Data = Serialize(data);
        }
    }
}
