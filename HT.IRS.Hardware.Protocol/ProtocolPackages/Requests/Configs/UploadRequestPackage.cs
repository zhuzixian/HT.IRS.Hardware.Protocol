using HT.IRS.Hardware.Protocol.Data.Requests.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class UploadRequestPackage:RequestPackageBase
    {
        public UploadRequestPackage(string data):base(APIs.Configs.Upload)
        {
            Data = data;
        }

        public UploadRequestPackage(UploadRequestData data) : base(APIs.Configs.Upload)
        {
            Data = Serialize(data);
        }
    }
}
