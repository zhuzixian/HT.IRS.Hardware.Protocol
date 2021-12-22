using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class RequireResponsePackage:ResponsePackageBase<RequireResponseData>
    {
        public RequireResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Controls.Require, sequenceNo, data)
        {
        }

        public RequireResponsePackage(ushort sequenceNo, RequireResponseData data) 
            : base(APIs.Controls.Require, sequenceNo, data) 
        {
        }
    }
}
