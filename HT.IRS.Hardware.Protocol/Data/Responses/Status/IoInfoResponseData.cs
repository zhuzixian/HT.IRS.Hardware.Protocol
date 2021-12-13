namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class IoInfoResponseData : ResponseDataBase
    {
        public bool[] Di { get; set; }
        public bool[] Do { get; set; }
    }
}
