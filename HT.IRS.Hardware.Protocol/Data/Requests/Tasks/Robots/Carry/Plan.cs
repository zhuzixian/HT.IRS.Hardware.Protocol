namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.Carry
{
    public class Plan: PlanBase
    {
        public Plan()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.Navigate;

        public Param Param { get; set; }
    }

    public class Param
    {
        public CarryTask[] Carry { get; set; }
    }

    public class CarryTask
    {
        public int Type { get; set; }
        public string Source { get; set; }
        public string Target { get; set; }
    }
}
