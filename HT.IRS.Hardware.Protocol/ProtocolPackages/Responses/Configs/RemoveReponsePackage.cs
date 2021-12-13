namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class RemoveResponsePackage:ResponsePackageBase
    {
        public RemoveResponsePackage(string data):base(data)
        {
            Api = APIs.Configs.Remove;
        }
    }
}
