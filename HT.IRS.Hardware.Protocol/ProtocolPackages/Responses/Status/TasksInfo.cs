namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class Task:StatusResponsePackageBase
    {
        public Task(string data):base(data)
        {
            Api = Protocol.Api.StatusTask;
        }
    }
}
