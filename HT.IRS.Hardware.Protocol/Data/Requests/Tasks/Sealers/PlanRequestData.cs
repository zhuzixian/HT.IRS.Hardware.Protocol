namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Sealers
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public Param Param { get; set; }
    }

    public class Param
    {
    }
}
