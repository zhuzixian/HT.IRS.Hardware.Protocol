namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.DUnits
{
    public class StockInfo: Responses.Status.StockInfo
    {
        public bool IsTipsBoxExist { get; set; }
        public bool IsDiscardTipsBoxExist { get; set; }
        public bool IsWellPlateExist { get; set; }
        public bool IsTargetTubeTrayExist { get; set; }
        public bool IsCacheWellPlateExist { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
