using System;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class TroubleInfoResponseData:ResponseDataBase
    {
        public Trouble[] Troubles { get; set; }
    }

    public class Trouble
    {
        public Guid Id { get; set; }
        public int Dtc { get; set; }
        public int Type { get; set; }
        public long DurationSeconds { get; set; }
        public string Description { get; set; }
        public string Trip { get; set; }
    }
}
