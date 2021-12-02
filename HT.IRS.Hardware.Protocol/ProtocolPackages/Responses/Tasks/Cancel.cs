namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    internal class Cancel:ResponsePackageBase
    {
        public Cancel(string data) : base(data)
        {
            Api = Protocol.Api.TaskCancel;
        }
    }
}
