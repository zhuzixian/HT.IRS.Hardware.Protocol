namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class Resume:TaskRequestPackageBase
    {
        public Resume(string data) : base(data)
        {
            Api = Protocol.Api.TaskResume;
        }
    }
}
