using HT.IRS.Hardware.Protocol.Data.Responses.Tasks;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class ResumeResponsePackage:ResponsePackageBase<ResumeResponseData>
    {
        public ResumeResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Resume, sequenceNo, data)
        {
            Api = APIs.Tasks.Resume;
        }
    }
}
