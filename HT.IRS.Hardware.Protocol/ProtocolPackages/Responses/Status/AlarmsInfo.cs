namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class AlarmsInfo: ResponsePackageBase
    {
        public AlarmsInfo(string data):base(data)
        {
            Api = Protocol.Api.StatusAlarm;
        }
    }
}
