namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class RunResponsePackage:ResponsePackageBase
    {
        public RunResponsePackage(string data) : base(data)
        {
            Api = APIs.Tasks.Run;
        }
    }
}
