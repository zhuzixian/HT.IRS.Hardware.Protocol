namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Pipettes.AbUnits
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Pipettes.AbUnits.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Pipettes.AbUnits.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
