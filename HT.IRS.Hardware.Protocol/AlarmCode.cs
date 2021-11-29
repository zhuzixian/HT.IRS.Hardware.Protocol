namespace HT.IRS.Hardware.Protocol
{
    public class AlarmCode
    {
        #region Fatal
        public const int InternalError = 51001;
        public const int ResourceExhaustion = 51002;
        public const int ParseError = 51003;
        public const int LoadError = 51004;
        public const int HardwareConnectError = 51005;
        public const int IsBlocked = 51006;
        public const int EmergencyStop = 51007;
        #endregion


        #region Waring
        public const int IsExecuting = 52002;
        public const int HasObstacles = 52003;
        #endregion


        #region Notice
        public const int FileSystemError = 53001;
        public const int ParamSystemError = 53002;
        public const int DatabaseError = 53003;
        public const int JsonConversionError = 53004;
        public const int SelfCheckingFailed = 53005;
        #endregion
    }
}
