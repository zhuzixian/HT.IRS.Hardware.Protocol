using HT.IRS.Hardware.Protocol.Data.Responses;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks
{
    public class CompleteResponsePackage<T>:ResponsePackageBase<T>
        where T:ResponseDataBase
    {
        public CompleteResponsePackage(ushort sequenceNo, string data)
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, T data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
