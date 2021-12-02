namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    internal class Cancel:TaskRequestPackageBase
    {
        public Cancel(string data) : base(data)
        {
            Api = Protocol.Api.TaskCancel;
        }
    }
}
