namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Robots.PickPlace
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Robots.PickPlace.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Robots.PickPlace.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
