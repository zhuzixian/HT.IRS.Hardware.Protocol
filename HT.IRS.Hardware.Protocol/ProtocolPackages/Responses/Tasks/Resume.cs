namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class Resume:ResponsePackageBase
    {
        public Resume(string data) : base(data)
        {
            Api = Protocol.Api.TaskResume;
        }
    }
}
