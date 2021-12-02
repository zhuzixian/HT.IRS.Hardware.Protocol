namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class Download:RequestPackageBase
    {
        public Download()
        {
            Api = Protocol.Api.ConfigDownload;
        }
    }
}
