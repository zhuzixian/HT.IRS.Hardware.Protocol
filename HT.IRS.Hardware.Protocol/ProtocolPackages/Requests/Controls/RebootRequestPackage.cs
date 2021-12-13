namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class RebootRequestPackage:RequestPackageBase
    {
        public RebootRequestPackage()
        {
            Api = APIs.Controls.Reboot;
        }
    }
}
