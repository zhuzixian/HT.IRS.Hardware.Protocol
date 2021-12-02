namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ParamInfo: ResponsePackageBase
    {
        public ParamInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusParam;
        }
    }
}
