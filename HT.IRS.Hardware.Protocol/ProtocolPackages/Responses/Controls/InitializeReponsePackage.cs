using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class InitializeResponsePackage:ResponsePackageBase<InitializeResponseData>
    {
        public InitializeResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Controls.Initialize, sequenceNo, data)
        {
        }

        public InitializeResponsePackage(ushort sequenceNo, InitializeResponseData data) 
            : base(APIs.Controls.Initialize, sequenceNo, data)
        {
        }
    }
}
