namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class StatusResponsePackageBase:ResponsePackageBase
    {
        public StatusResponsePackageBase(string data)
        {
            Data = data;
        }
    }
}
