using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class ReleaseResponsePackage:ResponsePackageBase<ReleaseResponseData>
    {
        public ReleaseResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Controls.Release, sequenceNo, data)
        {
        }

        public ReleaseResponsePackage(ushort sequenceNo, ReleaseResponseData data) 
            : base(APIs.Controls.Release, sequenceNo, data)
        {
        }
    }
}
