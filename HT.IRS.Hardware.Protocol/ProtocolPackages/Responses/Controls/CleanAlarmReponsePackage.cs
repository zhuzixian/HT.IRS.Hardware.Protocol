using HT.IRS.Hardware.Protocol.Data.Responses.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class CleanAlarmResponsePackage:ResponsePackageBase<CleanAlarmResponseData>
    {
        public CleanAlarmResponsePackage(ushort sequenceNo, string data)
            :base(sequenceNo, APIs.Controls.CleanAlarm, data)
        {
        }

        public CleanAlarmResponsePackage(ushort sequenceNo, CleanAlarmResponseData data) 
            : base(sequenceNo, APIs.Controls.CleanAlarm, data)
        {
        }
    }
}
