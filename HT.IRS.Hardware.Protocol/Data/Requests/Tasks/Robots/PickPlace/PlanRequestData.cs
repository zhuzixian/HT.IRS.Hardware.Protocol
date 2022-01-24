using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.PickPlace
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowType.PickPlace;

        public Param Param { get; set; }
    }

    public class Param
    {
        public IEnumerable<PickPlaceProcedure> Procedures { get; set; }
    }

    public class PickPlaceProcedure
    {
        public MaterialSeat Source { get; set; }
        public MaterialSeat Target { get; set; }
    }


}
