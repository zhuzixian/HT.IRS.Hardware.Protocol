using System;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Controls
{
    public class CleanAlarm:ResponseBase
    {
        public Guid[] Alarms { get; set; }
    }
}
