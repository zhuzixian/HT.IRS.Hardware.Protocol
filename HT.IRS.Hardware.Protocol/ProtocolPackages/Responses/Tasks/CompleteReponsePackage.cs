namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class CompleteResponsePackage:ResponsePackageBase
    {
        public CompleteResponsePackage(string data) : base(data)
        {
            Api = Protocol.APIs.Tasks.Complete;
        }
    }
}
