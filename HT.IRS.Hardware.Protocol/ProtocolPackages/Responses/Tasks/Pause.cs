namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class Pause:ResponsePackageBase
    {
        public Pause(string data) : base(data)
        {
            Api = Protocol.Api.TaskPause;
        }
    }
}
