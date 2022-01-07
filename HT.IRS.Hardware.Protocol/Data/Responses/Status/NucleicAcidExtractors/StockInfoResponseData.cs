namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.NucleicAcidExtractors
{
    public class StockInfoResponseData: Status.StockInfoResponseData
    {
        public int WellPlate1 { get; set; }
        public int WellPlate2 { get; set; }
        public int WellPlate3 { get; set; }
        public int WellPlate4 { get; set; }
        public int TipsBox { get; set; }
    }
}
