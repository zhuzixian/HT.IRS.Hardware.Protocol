namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class Complete:TaskRequestPackageBase
    {
        public Complete(string data) : base(data)
        {
            Api = Protocol.Api.TaskComplete;
        }
    }
}
