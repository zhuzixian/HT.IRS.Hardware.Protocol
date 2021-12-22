namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.Pipettes.DUnits
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.Pipettes.DUnits.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) 
            : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.Pipettes.DUnits.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
