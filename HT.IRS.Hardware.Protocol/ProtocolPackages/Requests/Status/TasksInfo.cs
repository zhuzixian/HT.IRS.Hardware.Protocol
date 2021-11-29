namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class TasksInfo:RequestPackageBase
    {
        public TasksInfo(string data = default)
        {
            Api = Protocol.Api.StatusTask;
            Data = data;
        }
    }
}
