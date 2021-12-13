namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class InitializeRequestPackage:RequestPackageBase
    {
        public InitializeRequestPackage(string data = default)
        {
            Data = data;
            Api = APIs.Controls.Initialize;
        }
    }
}
