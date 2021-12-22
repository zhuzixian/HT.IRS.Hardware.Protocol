using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class ReloadParamsResponsePackage:ResponsePackageBase<ReloadParamsResponseData>
    {
        public ReloadParamsResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Configs.ReloadParams, sequenceNo, data) 
        {
        }

        public ReloadParamsResponsePackage(ushort sequenceNo, ReloadParamsResponseData data) 
            : base(APIs.Configs.ReloadParams, sequenceNo, data) 
        {
        }
    }
}
