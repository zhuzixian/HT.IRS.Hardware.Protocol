namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class Download:ResponsePackageBase
    {
        public Download(string data):base(data)
        {
            Api = Protocol.Api.ConfigDownload;
        }
    }
}
