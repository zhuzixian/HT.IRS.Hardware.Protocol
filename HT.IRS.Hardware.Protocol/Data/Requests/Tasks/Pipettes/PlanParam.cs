namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Pipettes
{
    public class PlanParam
    {
        public bool IsReplaceDiscardTipsBox { get; set; }
        public Pipetting[] Pipettings { get; set; }
    }
}
