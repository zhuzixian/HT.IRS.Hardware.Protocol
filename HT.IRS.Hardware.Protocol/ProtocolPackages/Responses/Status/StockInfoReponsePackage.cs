using HT.IRS.Hardware.Protocol.Data.Responses;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class StockInfoResponsePackage<T>: ResponsePackageBase<T>
        where T : ResponseDataBase
    {
        public StockInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetStockInfos, sequenceNo, data)
        {
        }

        public StockInfoResponsePackage(ushort sequenceNo, T data) 
            : base(APIs.Status.GetStockInfos, sequenceNo, data)
        {
        }
    }
}
