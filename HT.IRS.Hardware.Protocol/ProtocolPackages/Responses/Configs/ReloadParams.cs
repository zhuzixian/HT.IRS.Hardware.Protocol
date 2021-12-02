namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class ReloadParams:ResponsePackageBase
    {
        public ReloadParams(string data) : base(data)
        {
            Api = Protocol.Api.ConfigReloadParams;
        }
    }
}
