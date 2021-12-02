namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class Release:ResponsePackageBase
    {
        public Release(string data):base(data)
        {
            Api = Protocol.Api.ControlRelease;
        }
    }
}
