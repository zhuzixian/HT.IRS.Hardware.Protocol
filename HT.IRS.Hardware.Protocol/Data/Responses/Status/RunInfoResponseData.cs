namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class RunInfoResponseData:ResponseDataBase
    {
        public long StartupSeconds { get; set; }
        public long TotalSeconds { get; set; }
        public double Soc { get; set; }
        public int State { get; set; }
    }

    public class RunState
    {
        public const int Readying = 0;
        public const int PowerOff = 1;
        public const int WaitingForInitialize = 2;
        public const int Busying = 3;
        public const int Running = 4;
        public const int Error = 5;
    }
}
