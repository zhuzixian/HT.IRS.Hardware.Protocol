namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class Reboot:RequestPackageBase
    {
        public Reboot()
        {
            Api = Protocol.Api.ControlReboot;
        }
    }
}
