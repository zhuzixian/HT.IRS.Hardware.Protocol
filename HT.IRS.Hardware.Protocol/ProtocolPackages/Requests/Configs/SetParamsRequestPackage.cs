namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class SetParamsRequestPackage:RequestPackageBase
    {
        public SetParamsRequestPackage(string data)
        {
            Api = APIs.Configs.SetParams;
            Data = data;
        }
    }
}
