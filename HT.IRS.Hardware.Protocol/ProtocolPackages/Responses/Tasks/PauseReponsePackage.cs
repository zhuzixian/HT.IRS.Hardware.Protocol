namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class PauseResponsePackage:ResponsePackageBase
    {
        public PauseResponsePackage(string data) : base(data)
        {
            Api = APIs.Tasks.Pause;
        }
    }
}
