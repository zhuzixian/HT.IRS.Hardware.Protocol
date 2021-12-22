using System;
using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Requests.Controls
{
    public class CleanAlarmRequestData
    {
        public IEnumerable<Guid> Alarms { get; set; }
    }
}
