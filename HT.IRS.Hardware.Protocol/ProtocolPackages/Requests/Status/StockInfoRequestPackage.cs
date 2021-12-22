namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class StockInfoRequestPackage:RequestPackageBase
    {
        public StockInfoRequestPackage():base(APIs.Status.GetStockInfos)
        {
        }
    }
}
