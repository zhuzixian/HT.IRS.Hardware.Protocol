namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class UploadResponsePackage : ResponsePackageBase
    {
        public UploadResponsePackage(string data) : base(data)
        {
            Api = APIs.Configs.Upload;
        }
    }
}
