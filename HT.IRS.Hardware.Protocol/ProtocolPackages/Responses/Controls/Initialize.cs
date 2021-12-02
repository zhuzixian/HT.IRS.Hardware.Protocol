namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class Initialize:ResponsePackageBase
    {
        public Initialize(string data):base(data)
        {
            Api = Protocol.Api.ControlInitialize;
        }
    }
}
