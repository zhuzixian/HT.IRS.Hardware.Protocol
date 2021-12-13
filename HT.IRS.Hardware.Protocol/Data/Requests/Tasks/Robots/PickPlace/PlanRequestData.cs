using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Tasks.Robots.PickPlace
{
    public class PlanRequestData: PlanBaseRequestData
    {
        public PlanRequestData()
        {
            Param = new Param();
        }

        public override int Type => WorkFlowTypeRequestData.PickPlace;

        public Param Param { get; set; }
    }

    public class Param
    {
        public IEnumerable<PickPlaceProcedure> Procedures { get; set; }
    }

    public class PickPlaceProcedure
    {
        public MaterialPositions.MaterialPosition Source { get; set; }
        public MaterialPositions.MaterialPosition Target { get; set; }
    }


}
