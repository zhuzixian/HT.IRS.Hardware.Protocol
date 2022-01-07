namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Sealers
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Sealers.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Sealers.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
