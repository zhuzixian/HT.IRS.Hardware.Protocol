namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.DUnits
{
    public class StockInfo: Status.StockInfo
    {
        public int TipsBox { get; set; }
        public int DiscardTipsBox { get; set; }
        public int WellPlate { get; set; }
        public int TargetTubeTray { get; set; }
        public int CacheWellPlate { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
