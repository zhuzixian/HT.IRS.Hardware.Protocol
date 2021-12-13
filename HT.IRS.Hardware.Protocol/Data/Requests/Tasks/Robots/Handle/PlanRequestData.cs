namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.Handle
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowTypeRequestData.Handle;

        public Param Param { get; set; }
    }

    public class Param
    {
        public int Action { get; set; }
        public string Target { get; set; }
    }
}
