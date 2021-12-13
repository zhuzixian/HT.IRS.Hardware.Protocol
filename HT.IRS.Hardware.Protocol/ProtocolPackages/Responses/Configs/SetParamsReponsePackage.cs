namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class SetParamsResponsePackage:ResponsePackageBase
    {
        public SetParamsResponsePackage(string data):base(data)
        {
            Api = APIs.Configs.SetParams;
        }
    }
}
