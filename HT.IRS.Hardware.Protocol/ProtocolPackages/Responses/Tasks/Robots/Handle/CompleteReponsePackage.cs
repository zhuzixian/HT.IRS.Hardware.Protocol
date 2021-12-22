namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Robots.Handle
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Robots.Handle.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Robots.Handle.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }
    }
}
