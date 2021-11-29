namespace HT.IRS.Hardware.Protocol
{
    public class ResponseCode
    {
        public const int Unavailable = 41001;
        public const int ParamMissing = 41002;
        public const int ParamTypeError = 41003;
        public const int ParamIllegal = 41004;
        public const int ErrorHugeDataRes = 41005;
        public const int ErrorDataRes = 41006;
        public const int ErrorVersionRes = 41007;

        public const int ModeError = 42001;
        public const int ShutdownError = 42002;
        public const int RebootError = 42003;
        public const int Dispatching = 42004;
        public const int RequestTimeout = 42005;
        public const int RequestForbidden = 42006;
        public const int Busy = 42007;
        public const int LoadWorkflowError = 42008;
        public const int InitStatusError = 42009;

        public const int EmptyProgram = 43002;
        public const int FileNotExists = 43003;
        public const int SetParamTypeError = 43004;
        public const int SetParamError = 43005;
        public const int SetParamNotExists = 43006;
        public const int ReloadParamError = 43007;
        public const int InternalError = 43008;
    }
}
