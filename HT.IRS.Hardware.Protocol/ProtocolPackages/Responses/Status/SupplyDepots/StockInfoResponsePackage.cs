namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.SupplyDepots
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.SupplyDepots.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.SupplyDepots.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
