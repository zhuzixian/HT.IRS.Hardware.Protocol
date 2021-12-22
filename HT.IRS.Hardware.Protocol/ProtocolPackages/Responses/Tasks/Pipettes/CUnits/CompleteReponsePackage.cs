namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Pipettes.CUnits
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Pipettes.CUnits.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Pipettes.CUnits.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }
    }
}
