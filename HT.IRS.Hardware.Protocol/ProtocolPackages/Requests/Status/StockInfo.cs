namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class StockInfo:RequestPackageBase
    {
        public StockInfo()
        {
            Api = Protocol.Api.StatusStock;
        }
    }
}
