namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class Release:RequestPackageBase
    {
        public Release()
        {
            Api = Protocol.Api.ControlRelease;
        }
    }
}
