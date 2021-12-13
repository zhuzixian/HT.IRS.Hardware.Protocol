namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes.AbUnits
{
    public class CompleteResponseData:Tasks.CompleteResponseData
    {
        public CompleteOutputResult Data { get; set; } 
    }

    public class CompleteOutputResult: Pipettes.CompleteResponseData
    {
    }
}
