
using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Robots
{
    public class StockInfo: Status.StockInfo
    {
        public IEnumerable<StockInfoItem> Stock { get; set; }
    }

    public class StockInfoItem
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public string Count { get; set; }
    }
}
