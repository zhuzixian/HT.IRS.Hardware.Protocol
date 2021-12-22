using HT.IRS.Hardware.Protocol.Data.Responses;
using HT.IRS.Hardware.Protocol.Data.Responses.Configs;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Configs
{
    public class DownloadResponsePackage:ResponsePackageBase<ReloadParamsResponseData>
    {
        public DownloadResponsePackage(ushort sequenceNo, string data):base(APIs.Configs.Download, sequenceNo, data)
        {
        }

        public DownloadResponsePackage(ushort sequenceNo, ReloadParamsResponseData data):base(APIs.Configs.Download, sequenceNo, data)
        {
        }
    }
}
