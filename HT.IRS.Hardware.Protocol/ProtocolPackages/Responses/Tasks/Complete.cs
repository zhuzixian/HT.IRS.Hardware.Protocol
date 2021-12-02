namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class Complete:ResponsePackageBase
    {
        public Complete(string data) : base(data)
        {
            Api = Protocol.Api.TaskComplete;
        }
    }
}
