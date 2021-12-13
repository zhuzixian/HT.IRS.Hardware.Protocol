namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class StockInfoRequestPackage:RequestPackageBase
    {
        public StockInfoRequestPackage()
        {
            Api = APIs.Status.GetStockInfos;
        }
    }
}
