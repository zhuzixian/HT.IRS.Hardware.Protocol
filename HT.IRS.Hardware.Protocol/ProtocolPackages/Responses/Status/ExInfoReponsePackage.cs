namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ExInfoResponsePackage: ResponsePackageBase
    {
        public ExInfoResponsePackage(string data) : base(data)
        {
            Api = APIs.Status.GetExInfos;
        }
    }
}
