namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.Navigate
{
    public class Plan: PlanBase
    {
        public Plan()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Carry;

        public Param Param { get; set; }
    }

    public class Param
    {
        public string Target { get; set; }
    }
}
