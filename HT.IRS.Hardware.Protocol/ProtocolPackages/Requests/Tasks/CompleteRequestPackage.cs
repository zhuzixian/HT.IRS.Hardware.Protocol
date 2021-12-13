namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Tasks
{
    public class CompleteRequestPackage:TaskRequestPackageBase
    {
        public CompleteRequestPackage(string data) : base(data)
        {
            Api = APIs.Tasks.Complete;
        }
    }
}
