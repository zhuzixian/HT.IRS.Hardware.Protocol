namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.CUnits
{
    public class StockInfo: Responses.Status.StockInfo
    {
        public bool IsSampleTrayExist { get; set; }
        public bool IsTipsBoxExist { get; set; }
        public bool IsDiscardTipsBoxExist { get; set; }
        public bool IsWellPlateExist { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
