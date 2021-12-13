namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.CUnits
{
    public class StockInfoResponseData: Responses.Status.StockInfoResponseData
    {
        public int SampleTray { get; set; }
        public int TipsBox { get; set; }
        public int DiscardTipsBox { get; set; }
        public int WellPlate { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
