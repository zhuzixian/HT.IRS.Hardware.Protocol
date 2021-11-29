namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class AlarmsInfo:RequestPackageBase
    {
        public AlarmsInfo()
        {
            Api = Protocol.Api.StatusAlarm;
        }
    }
}
