using System;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Controls
{
    public class CleanAlarmResponseData:ResponseDataBase
    {
        public Guid[] Alarms { get; set; }
    }
}
