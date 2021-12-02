namespace HT.IRS.Hardware.Protocol
{
    public class Api
    {
        #region 状态查询
        public const ushort StatusInfo = 1001;
        public const ushort StatusRun = 1002;
        public const ushort StatusEmergency = 1003;
        public const ushort StatusIo = 1004;
        public const ushort StatusAlarm = 1005;
        public const ushort StatusWorkflow = 1006;
        public const ushort StatusParam = 1007;
        public const ushort StatusTask = 1008;
        public const ushort StatusStock = 1009;
        public const ushort StatusEx = 1101;
        #endregion

        #region 控制
        public const ushort ControlRequire = 2101;
        public const ushort ControlRelease = 2102;
        public const ushort ControlInitialize = 2001;
        public const ushort ControlShutdown = 2002;
        public const ushort ControlReboot = 2003;
        public const ushort ControlCleanAlarm = 2004;
        #endregion

        #region 任务
        public const ushort TaskPlan = 3001;
        public const ushort TaskRun = 3002;
        public const ushort TaskPause = 3003;
        public const ushort TaskResume = 3004;
        public const ushort TaskCancel = 3005;
        public const ushort TaskComplete = 3006;
        #endregion

        #region 配置
        public const ushort ConfigUpload = 4003;
        public const ushort ConfigDownload = 4004;
        public const ushort ConfigRemove = 4005;
        public const ushort ConfigSetParams = 4006;
        public const ushort ConfigReloadParams = 4007;
        public const ushort ConfigDefaultWorkflow = 4008;
        #endregion

    }
}
