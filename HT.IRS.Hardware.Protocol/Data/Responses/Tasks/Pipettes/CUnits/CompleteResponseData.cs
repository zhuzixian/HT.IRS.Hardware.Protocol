namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes.CUnits
{
    public class CompleteResponseData:ResponseDataBase
    {
        public CompleteOutputResult Data { get; set; } 
    }

    public class CompleteOutputResult: Pipettes.CompleteResponseData
    {
    }
}
