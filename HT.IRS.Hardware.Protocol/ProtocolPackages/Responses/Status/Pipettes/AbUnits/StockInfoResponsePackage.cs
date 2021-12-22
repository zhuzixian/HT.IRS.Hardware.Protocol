namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.Pipettes.AbUnits
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.Pipettes.AbUnits.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.Pipettes.AbUnits.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
