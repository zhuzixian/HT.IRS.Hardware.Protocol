namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class ResumeRequestPackage:TaskRequestPackageBase
    {
        public ResumeRequestPackage(string data) : base(data)
        {
            Api = APIs.Tasks.Resume;
        }
    }
}
