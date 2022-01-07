namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.NucleicAcidExtractors.TurnTray
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }
        public override int Type => WorkFlowType.TurnTray;

        public Param Param { get; set; }
    }

    public class Param
    {
        public int TrayId { get; set; }
    }
}
