namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class TasksInfoRequestPackage:RequestPackageBase
    {
        public TasksInfoRequestPackage():base(APIs.Status.GetTaskInfos)
        {
        }
    }
}
