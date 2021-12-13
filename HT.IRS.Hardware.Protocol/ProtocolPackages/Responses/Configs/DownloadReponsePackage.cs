namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class DownloadResponsePackage:ResponsePackageBase
    {
        public DownloadResponsePackage(string data):base(data)
        {
            Api = APIs.Configs.Download;
        }
    }
}
