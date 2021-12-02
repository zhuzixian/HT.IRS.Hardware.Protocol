namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Controls
{
    public class CleanAlarm:ResponsePackageBase
    {
        public CleanAlarm(string data):base(data)
        {
            Data = data;
            Api = Protocol.Api.ControlCleanAlarm;
        }
    }
}
