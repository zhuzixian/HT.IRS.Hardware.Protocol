namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class Task: ResponsePackageBase
    {
        public Task(string data):base(data)
        {
            Api = APIs.Status.GetTaskInfos;
        }
    }
}
