using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class RunInfoResponsePackage: ResponsePackageBase<RunInfoResponseData>
    {
        public RunInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetRunInfos, sequenceNo, data)
        {
        }

        public RunInfoResponsePackage(ushort sequenceNo, RunInfoResponseData data) 
            : base(APIs.Status.GetRunInfos, sequenceNo, data)
        {
        }
    }
}
