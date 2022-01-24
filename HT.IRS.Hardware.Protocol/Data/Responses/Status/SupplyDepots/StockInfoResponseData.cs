namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.SupplyDepots
{
    public class StockInfoResponseData: Status.StockInfoResponseData
    {
        public StockInfoResponseData(
            int tipsBoxSeat1, int tipsBoxSeat2, int tipsBoxSeat3,
            int sampleTraySeat1, int sampleTraySeat2,
            int wellPlateSeat1, int wellPlateSeat2, int wellPlateSeat3, int wellPlateSeat4,
            int multiTubeTraySeat, int abReagentTraySeat, 
            int recycleAbReagentTraySeat, int recycleSampleTraySeat,
            int recycleWellPlateSeat, int recycleMultiTubeTraySeat)
        {
            TipsBoxSeat1 = tipsBoxSeat1;
            TipsBoxSeat2 = tipsBoxSeat2;
            TipsBoxSeat3 = tipsBoxSeat3;

            SampleTraySeat1 = sampleTraySeat1;
            SampleTraySeat2 = sampleTraySeat2;

            WellPlateSeat1 = wellPlateSeat1;
            WellPlateSeat2 = wellPlateSeat2;
            WellPlateSeat3 = wellPlateSeat3;
            WellPlateSeat4 = wellPlateSeat4;

            MultiTubeTraySeat = multiTubeTraySeat;
            AbReagentTraySeat = abReagentTraySeat;

            RecycleAbReagentTraySeat = recycleAbReagentTraySeat;
            RecycleSampleTraySeat = recycleSampleTraySeat;
            RecycleWellPlateSeat = recycleWellPlateSeat;
            RecycleMultiTubeTraySeat = recycleMultiTubeTraySeat;
        }

        public int TipsBoxSeat1 { get; }
        public int TipsBoxSeat2 { get; }
        public int TipsBoxSeat3 { get; }
        public int SampleTraySeat1 { get; }
        public int SampleTraySeat2 { get; }
        public int WellPlateSeat1 { get; }
        public int WellPlateSeat2 { get; }
        public int WellPlateSeat3 { get; }
        public int WellPlateSeat4 { get; }
        public int MultiTubeTraySeat { get; }
        public int AbReagentTraySeat { get; }
        public int RecycleAbReagentTraySeat { get; }
        public int RecycleSampleTraySeat { get; }
        public int RecycleWellPlateSeat { get; }
        public int RecycleMultiTubeTraySeat { get; }
    }
}
