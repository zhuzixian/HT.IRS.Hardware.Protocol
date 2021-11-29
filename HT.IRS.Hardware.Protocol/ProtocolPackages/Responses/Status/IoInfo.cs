namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class IoInfo:StatusResponsePackageBase
    {
        public IoInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusIo;
        }
    }
}
