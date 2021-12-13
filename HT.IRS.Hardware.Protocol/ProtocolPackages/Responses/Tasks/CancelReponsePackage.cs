namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    internal class CancelResponsePackage:ResponsePackageBase
    {
        public CancelResponsePackage(string data) : base(data)
        {
            Api = APIs.Tasks.Cancel;
        }
    }
}
