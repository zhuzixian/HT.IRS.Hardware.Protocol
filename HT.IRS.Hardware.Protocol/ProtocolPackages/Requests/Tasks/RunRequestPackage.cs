namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class RunRequestPackage:TaskRequestPackageBase
    {
        public RunRequestPackage(string data) : base(data)
        {
            Api = Protocol.APIs.Tasks.Run;
        }
    }
}
