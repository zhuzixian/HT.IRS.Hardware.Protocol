namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ExInfo: ResponsePackageBase
    {
        public ExInfo(string data) : base(data)
        {
            Api = Protocol.Api.StatusEx;
        }
    }
}
