namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class IoInfoResponsePackage: ResponsePackageBase
    {
        public IoInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetIoInfos;
        }
    }
}
