using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.Data.Responses.Status.Robots
{
    public class StockInfoResponseData: Status.StockInfoResponseData
    {
        public StockInfoResponseData()
        {
            Stock = new List<StockInfoItem>();
        }

        public IEnumerable<StockInfoItem> Stock { get; set; }
    }

    public class StockInfoItem
    {
        public string Type { get; set; }
        public string Position { get; set; }
        public int Count { get; set; }
        public string Code { get; set; }
    }
}
