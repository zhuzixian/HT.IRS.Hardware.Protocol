namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class InitializeResponsePackage:ResponsePackageBase
    {
        public InitializeResponsePackage(string data):base(data)
        {
            Api = APIs.Controls.Initialize;
        }
    }
}
