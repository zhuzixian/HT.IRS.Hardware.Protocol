namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.AbUnits
{
    public class StockInfoResponseData: Pipettes.StockInfoResponseData
    {
        public int ATipsBox { get; set; }
        public int BTipsBox { get; set; }
        public int DiscardTipsBox { get; set; }
        public int AbReagentTray { get; set; }
        public int TargetTubesTray { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedATipsCount { get; set; }
        public int UsedBTipsCount { get; set; }
    }
}
