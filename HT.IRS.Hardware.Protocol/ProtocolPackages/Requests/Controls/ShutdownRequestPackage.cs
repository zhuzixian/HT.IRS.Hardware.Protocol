namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class ShutdownRequestPackage:RequestPackageBase
    {
        public ShutdownRequestPackage():base(APIs.Controls.Shutdown)
        {
        }
    }
}
