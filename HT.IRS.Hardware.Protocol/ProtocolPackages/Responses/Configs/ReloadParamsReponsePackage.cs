namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class ReloadParamsResponsePackage:ResponsePackageBase
    {
        public ReloadParamsResponsePackage(string data) : base(data)
        {
            Api = APIs.Configs.ReloadParams;
        }
    }
}
