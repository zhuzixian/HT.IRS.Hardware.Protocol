namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class Remove:ResponsePackageBase
    {
        public Remove(string data):base(data)
        {
            Api = Protocol.Api.ConfigRemove;
        }
    }
}
