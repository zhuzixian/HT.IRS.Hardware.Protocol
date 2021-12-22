namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class ParamInfoRequestPackage:RequestPackageBase
    {
        public ParamInfoRequestPackage():base(APIs.Status.GetParamInfos)
        {
        }
    }
}
