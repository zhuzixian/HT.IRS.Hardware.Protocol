namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class CancelRequestPackage:TaskRequestPackageBase
    {
        public CancelRequestPackage(string data) : base(data)
        {
            Api = APIs.Tasks.Cancel;
        }
    }
}
