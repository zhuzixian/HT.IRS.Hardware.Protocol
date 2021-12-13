namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class ShutdownRequestPackage:RequestPackageBase
    {
        public ShutdownRequestPackage()
        {
            Api = APIs.Controls.Shutdown;
        }
    }
}
