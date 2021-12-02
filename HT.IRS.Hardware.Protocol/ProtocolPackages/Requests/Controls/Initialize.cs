namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class Initialize:RequestPackageBase
    {
        public Initialize(string data = default)
        {
            Data = data;
            Api = Protocol.Api.ControlInitialize;
        }
    }
}
