namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Robots.Navigate
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Robots.Navigate.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Robots.Navigate.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }
    }
}
