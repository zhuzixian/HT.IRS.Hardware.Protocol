namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests
{
    public class RequestPackageBase:ProtocolPackage
    {
        public RequestPackageBase(ushort api)
        {
            Api = api;
            ProtocolVersion = 0x01;
            IsRequestMessage = true;
        }
    }
}
