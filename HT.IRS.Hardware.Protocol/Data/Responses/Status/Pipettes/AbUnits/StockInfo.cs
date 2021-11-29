namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.AbUnits
{
    public class StockInfo: Responses.Status.Pipettes.StockInfo
    {
        public bool IsATipsBoxExist { get; set; }
        public bool IsBTipsBoxExist { get; set; }
        public bool IsDiscardTipsBoxExist { get; set; }
        public bool IsAbReagentTrayExist { get; set; }
        public bool IsTargetTubesTrayExist { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
