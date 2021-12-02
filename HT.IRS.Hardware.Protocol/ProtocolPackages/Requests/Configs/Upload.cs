namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class Upload:RequestPackageBase
    {
        public Upload(string data)
        {
            Api = Protocol.Api.ConfigUpload; 
            Data = data;
        }
    }
}
