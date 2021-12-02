namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class Remove:RequestPackageBase
    {
        public Remove()
        {
            Api = Protocol.Api.ConfigRemove;
        }
    }
}
