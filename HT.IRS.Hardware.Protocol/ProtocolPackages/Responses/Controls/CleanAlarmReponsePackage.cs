namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class CleanAlarmResponsePackage:ResponsePackageBase
    {
        public CleanAlarmResponsePackage(string data):base(data)
        {
            Data = data;
            Api = APIs.Controls.CleanAlarm;
        }
    }
}
