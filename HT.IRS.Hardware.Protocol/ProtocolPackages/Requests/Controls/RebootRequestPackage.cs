namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class RebootRequestPackage:RequestPackageBase
    {
        public RebootRequestPackage():base(APIs.Controls.Reboot)
        {
        }
    }
}
