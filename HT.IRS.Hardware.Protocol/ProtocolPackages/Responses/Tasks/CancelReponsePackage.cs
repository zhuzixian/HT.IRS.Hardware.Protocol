using HT.IRS.Hardware.Protocol.Data.Responses.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    internal class CancelResponsePackage:ResponsePackageBase<CancelResponseData>
    {
        public CancelResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Cancel, sequenceNo, data)
        {
        }

        public CancelResponsePackage(ushort sequenceNo, CancelResponseData data) 
            : base(APIs.Tasks.Cancel, sequenceNo, data)
        {
        }
    }
}
