using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class UploadResponsePackage : ResponsePackageBase<UploadResponseData>
    {
        public UploadResponsePackage(ushort sequenceNo, string data) 
            : base(sequenceNo, APIs.Configs.Upload, data) 
        {
        }

        public UploadResponsePackage(ushort sequenceNo, UploadResponseData data) 
            : base(sequenceNo, APIs.Configs.Upload, data) 
        {
        }
    }
}
