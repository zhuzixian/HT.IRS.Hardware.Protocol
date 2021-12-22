using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class RebootResponsePackage:ResponsePackageBase<RebootResponseData>
    {
        public RebootResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Controls.Reboot, sequenceNo, data)
        {
        }

        public RebootResponsePackage(ushort sequenceNo, RebootResponseData data) 
            : base(APIs.Controls.Reboot, sequenceNo, data)
        {
        }
    }
}
