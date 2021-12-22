using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class RemoveResponsePackage: ResponsePackageBase<RemoveResponseData>
    {
        public RemoveResponsePackage(ushort sequenceNo, string data)
            : base(sequenceNo, APIs.Configs.Remove, data)
        {
        }

        public RemoveResponsePackage(ushort sequenceNo, RemoveResponseData data) 
            : base(sequenceNo, APIs.Configs.Remove, data)
        {
        }
    }
}
