using HT.IRS.Hardware.Protocol.Data.Requests.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class CancelRequestPackage:TaskRequestPackageBase
    {
        public CancelRequestPackage(string data) : base(APIs.Tasks.Cancel, data)
        {
        }

        public CancelRequestPackage(CancelRequestData data) : base(APIs.Tasks.Cancel)
        {
            Data = Serialize(data);
        }
    }
}
