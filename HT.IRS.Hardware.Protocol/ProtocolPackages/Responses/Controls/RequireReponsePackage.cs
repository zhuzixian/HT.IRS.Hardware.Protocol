namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class RequireResponsePackage:ResponsePackageBase
    {
        public RequireResponsePackage(string data):base(data)
        {
            Api = APIs.Controls.Require;
        }
    }
}
