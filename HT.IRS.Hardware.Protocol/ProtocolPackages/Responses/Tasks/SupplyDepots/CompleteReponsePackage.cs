namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.SupplyDepots
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.SupplyDepots.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.SupplyDepots.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
