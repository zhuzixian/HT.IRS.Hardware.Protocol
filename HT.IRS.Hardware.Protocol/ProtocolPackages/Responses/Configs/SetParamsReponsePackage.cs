using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class SetParamsResponsePackage:ResponsePackageBase<SetParamsResponseData>
    {
        public SetParamsResponsePackage(ushort sequenceNo, string data)
            :base(sequenceNo, APIs.Configs.SetParams, data)
        {
        }
    }
}
