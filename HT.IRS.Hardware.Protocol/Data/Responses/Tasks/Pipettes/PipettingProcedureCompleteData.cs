namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes
{
    public class PipettingProcedureCompleteData
    {
        public bool IsCompleted { get; set; }
        public string Trouble { get; set; }

        public LocationCompleteData Source { get; set; }
        public LocationCompleteData Target { get; set; }
    }

    public class LocationCompleteData : Location
    {
        public string SourceCode { get; set; }
    }
}
