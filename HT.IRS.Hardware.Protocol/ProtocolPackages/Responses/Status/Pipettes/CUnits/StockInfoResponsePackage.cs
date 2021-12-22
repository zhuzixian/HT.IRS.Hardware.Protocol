namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status.Pipettes.CUnits
{
    public class StockInfoResponsePackage : StockInfoResponsePackage<Data.Responses.Status.Pipettes.CUnits.StockInfoResponseData>
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data) 
            : base(sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, Data.Responses.Status.Pipettes.CUnits.StockInfoResponseData data) 
            : base(sequenceNo, data)
        {
        }
    }
}
