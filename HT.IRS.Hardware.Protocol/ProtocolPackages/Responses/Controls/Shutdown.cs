namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class Shutdown:ResponsePackageBase
    {
        public Shutdown(string data):base(data)
        {
            Api = Protocol.Api.ControlShutdown;
        }
    }
}
