namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class StockInfoResponsePackage: ResponsePackageBase
    {
        public StockInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetStockInfos;
        }
    }
}
