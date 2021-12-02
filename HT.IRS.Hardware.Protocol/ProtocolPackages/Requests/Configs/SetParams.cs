namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class SetParams:RequestPackageBase
    {
        public SetParams(string data)
        {
            Api = Protocol.Api.ConfigSetParams;
            Data = data;
        }
    }
}
