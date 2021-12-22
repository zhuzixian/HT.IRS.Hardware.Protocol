namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.Navigate
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Navigate;

        public Param Param { get; set; }
    }

    public class Param
    {
        public string Target { get; set; }
    }
}
