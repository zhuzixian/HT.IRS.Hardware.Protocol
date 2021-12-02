namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Pipettes.AbUnits
{
    public class StockInfo: Responses.Status.Pipettes.StockInfo
    {
        public int ATipsBox { get; set; }
        public int BTipsBox { get; set; }
        public int DiscardTipsBox { get; set; }
        public int AbReagentTray { get; set; }
        public int TargetTubesTray { get; set; }
        public int UsedTipSeatsCount { get; set; }
        public int UsedTipsCount { get; set; }
    }
}
