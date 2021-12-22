using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class ParamInfoResponsePackage: ResponsePackageBase<ParamInfoResponseData>
    {
        public ParamInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetParamInfos, sequenceNo, data)
        {
        }
        
        public ParamInfoResponsePackage(ushort sequenceNo, ParamInfoResponseData data)
            :base(APIs.Status.GetParamInfos, sequenceNo, data)
        {
        }
    }
}
