namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class TaskRequestPackageBase:RequestPackageBase
    {
        public TaskRequestPackageBase(ushort api, string data):base(api)
        {
            Data = data;
        }

        public TaskRequestPackageBase(ushort api) : base(api)
        {
        }
    }
}
