using System;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class AlarmInfo:ResponseBase
    {
        public Alarm[] Fatals { get; set; }
        public Alarm[] Errors { get; set; }
        public Alarm[] Warnings { get; set; }
        public Alarm[] Notices { get; set; }
    }

    public class Alarm
    {
        public Guid Id { get; set; }
        public int Type { get; set; }
        public long DurationSeconds { get; set; }
        public string Description { get; set; }
        public string Trip { get; set; }
    }
}
