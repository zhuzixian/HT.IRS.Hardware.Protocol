namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class Pause:TaskRequestPackageBase
    {
        public Pause(string data) : base(data)
        {
            Api = Protocol.Api.TaskPause;
        }
    }
}
