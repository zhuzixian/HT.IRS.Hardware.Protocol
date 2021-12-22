using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class CompleteRequestPackage:TaskRequestPackageBase
    {
        public CompleteRequestPackage(string data) : base(APIs.Tasks.Complete, data)
        {
        }

        public CompleteRequestPackage(CompleteRequestData data) : base(APIs.Tasks.Complete)
        {
            Data = Serialize(data);
        }
    }
}
