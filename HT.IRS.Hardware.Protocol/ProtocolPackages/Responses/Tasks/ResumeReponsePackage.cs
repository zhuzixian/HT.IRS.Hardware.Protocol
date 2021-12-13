namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class ResumeResponsePackage:ResponsePackageBase
    {
        public ResumeResponsePackage(string data) : base(data)
        {
            Api = Protocol.APIs.Tasks.Resume;
        }
    }
}
