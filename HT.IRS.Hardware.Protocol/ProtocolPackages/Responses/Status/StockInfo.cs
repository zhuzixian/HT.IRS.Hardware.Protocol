namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class StockInfo:StatusResponsePackageBase
    {
        public StockInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusStock;
        }
    }
}
