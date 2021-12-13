namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class AlarmsInfoResponsePackage: ResponsePackageBase
    {
        public AlarmsInfoResponsePackage(string data):base(data)
        {
            Api = APIs.Status.GetAlarmInfos;
        }
    }
}
