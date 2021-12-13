namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class TasksInfoRequestPackage:RequestPackageBase
    {
        public TasksInfoRequestPackage()
        {
            Api = APIs.Status.GetTaskInfos;
        }
    }
}
