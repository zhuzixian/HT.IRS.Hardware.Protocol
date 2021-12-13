namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class ShutdownResponsePackage:ResponsePackageBase
    {
        public ShutdownResponsePackage(string data):base(data)
        {
            Api = APIs.Controls.Shutdown;
        }
    }
}
