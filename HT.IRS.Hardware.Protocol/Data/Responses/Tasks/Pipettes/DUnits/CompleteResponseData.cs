namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes.DUnits
{
    public class CompleteResponseData: Tasks.CompleteResponseData
    {
        public CompleteOutputResult Data { get; set; } 
    }

    public class CompleteOutputResult:Pipettes.CompleteResponseData
    {
    }
}
