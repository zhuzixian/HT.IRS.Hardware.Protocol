namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ParamInfoResponsePackage: ResponsePackageBase
    {
        public ParamInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetParamInfos;
        }
    }
}
