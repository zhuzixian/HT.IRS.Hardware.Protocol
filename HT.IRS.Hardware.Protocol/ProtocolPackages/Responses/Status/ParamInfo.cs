namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ParamInfo:StatusResponsePackageBase
    {
        public ParamInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusParam;
        }
    }
}
