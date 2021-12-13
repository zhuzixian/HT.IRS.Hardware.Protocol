namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class CleanAlarmRequestPackage:RequestPackageBase
    {
        public CleanAlarmRequestPackage(string data = default)
        {
            Data = data;
            Api = APIs.Controls.CleanAlarm;
        }
    }
}
