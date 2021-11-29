using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Robots
{
    public class StockInfo: Responses.Status.StockInfo
    {
        public Dictionary<string, bool> Stock { get; set; }
    }
}
