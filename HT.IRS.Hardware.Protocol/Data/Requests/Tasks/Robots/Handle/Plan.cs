namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.Handle
{
    public class Plan: PlanBase
    {
        public Plan()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Handle;

        public Param Param { get; set; }
    }

    public class Param
    {
        public int Action { get; set; }
        public string Target { get; set; }
    }
}
