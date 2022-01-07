namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.NucleicAcidExtractors.Extract
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Extract;
        public Param Param { get; set; }
    }

    public class Param
    {
    }
}
