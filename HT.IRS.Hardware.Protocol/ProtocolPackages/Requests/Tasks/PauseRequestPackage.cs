namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class PauseRequestPackage:TaskRequestPackageBase
    {
        public PauseRequestPackage(string data) : base(data)
        {
            Api = APIs.Tasks.Pause;
        }
    }
}
