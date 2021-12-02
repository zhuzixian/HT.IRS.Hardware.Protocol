namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class Upload : ResponsePackageBase
    {
        public Upload(string data) : base(data)
        {
            Api = Protocol.Api.ConfigUpload;
        }
    }
}
