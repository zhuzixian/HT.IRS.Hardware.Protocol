namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses
{
    public class ResponsePackageBase:ProtocolPackage
    {
        public ResponsePackageBase(string data)
        {
            Data = data;
            IsRequestMessage = false;
        }
    }
}
