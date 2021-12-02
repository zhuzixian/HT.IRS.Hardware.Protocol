namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class Require:ResponsePackageBase
    {
        public Require(string data):base(data)
        {
            Api = Protocol.Api.ControlRequire;
        }
    }
}
