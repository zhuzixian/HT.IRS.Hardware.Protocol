namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class ReleaseResponsePackage:ResponsePackageBase
    {
        public ReleaseResponsePackage(string data):base(data)
        {
            Api = APIs.Controls.Release;
        }
    }
}
