namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Pipettes
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Pipettes.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Pipettes.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }
    }
}
