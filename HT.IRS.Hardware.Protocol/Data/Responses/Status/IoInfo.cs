namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class IOInfo : ResponseBase
    {
        public bool[] Di { get; set; }
        public bool[] Do { get; set; }
    }
}
