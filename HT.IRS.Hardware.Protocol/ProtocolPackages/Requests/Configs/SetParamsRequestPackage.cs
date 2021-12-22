using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Configs
{
    public class SetParamsRequestPackage:RequestPackageBase
    {
        public SetParamsRequestPackage(string data):base( APIs.Configs.SetParams)
        {
            Data = data;
        }

        public SetParamsRequestPackage(SetParamsResponseData data) : base(APIs.Configs.SetParams)
        {
            Data = Serialize(data);
        }
    }
}
