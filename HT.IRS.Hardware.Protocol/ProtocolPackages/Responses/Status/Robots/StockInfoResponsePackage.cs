namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.Robots
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.Robots.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.Robots.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
