using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class ShutdownResponsePackage:ResponsePackageBase<ShutdownResponseData>
    {
        public ShutdownResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Controls.Shutdown, sequenceNo, data)
        {
        }

        public ShutdownResponsePackage(ushort sequenceNo, ShutdownResponseData data) 
            : base(APIs.Controls.Shutdown, sequenceNo, data)
        {
        }
    }
}
