namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class CleanAlarm:RequestPackageBase
    {
        public CleanAlarm(string data = default)
        {
            Data = data;
            Api = Protocol.Api.ControlCleanAlarm;
        }
    }
}
