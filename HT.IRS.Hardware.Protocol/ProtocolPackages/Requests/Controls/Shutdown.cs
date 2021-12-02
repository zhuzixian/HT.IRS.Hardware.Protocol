namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class Shutdown:RequestPackageBase
    {
        public Shutdown()
        {
            Api = Protocol.Api.ControlShutdown;
        }
    }
}
