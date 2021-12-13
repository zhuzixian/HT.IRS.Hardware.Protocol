namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Status
{
    public class AlarmsInfoRequestPackage:RequestPackageBase
    {
        public AlarmsInfoRequestPackage()
        {
            Api = APIs.Status.GetAlarmInfos;
        }
    }
}
