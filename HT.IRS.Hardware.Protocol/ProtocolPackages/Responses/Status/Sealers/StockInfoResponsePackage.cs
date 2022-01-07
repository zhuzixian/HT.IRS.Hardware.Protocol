namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.Sealers
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.Sealers.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.Sealers.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
