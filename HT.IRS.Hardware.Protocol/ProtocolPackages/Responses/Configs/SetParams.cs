namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class SetParams:ResponsePackageBase
    {
        public SetParams(string data):base(data)
        {
            Api = Protocol.Api.ConfigSetParams;
        }
    }
}
