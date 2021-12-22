using HT.IRS.Hardware.Protocol.Data.Requests.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class CleanAlarmRequestPackage:RequestPackageBase
    {
        public CleanAlarmRequestPackage(string data = default):base(APIs.Controls.CleanAlarm)
        {
            Data = data;
        }

        public CleanAlarmRequestPackage(CleanAlarmRequestData data = default) : base(APIs.Controls.CleanAlarm)
        {
            if (data != default)
            {
                Data = Serialize(data);
            }
        }
    }
}
