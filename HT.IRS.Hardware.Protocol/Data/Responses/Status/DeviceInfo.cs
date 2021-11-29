namespace HT.IRS.Hardware.Protocol.Data.Responses.Status
{
    public class DeviceInfo : ResponseBase
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Version { get; set; }
        public string Type { get; set; }
        public string SoftwareVersion { get; set; }
    }
}
