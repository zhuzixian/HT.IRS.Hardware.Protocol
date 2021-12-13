namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class UploadRequestPackage:RequestPackageBase
    {
        public UploadRequestPackage(string data)
        {
            Api = APIs.Configs.Upload; 
            Data = data;
        }
    }
}
