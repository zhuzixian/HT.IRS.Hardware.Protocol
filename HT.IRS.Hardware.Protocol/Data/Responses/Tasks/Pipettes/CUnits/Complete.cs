﻿namespace HT.IRS.Hardware.Protocol.Data.Responses.Tasks.Pipettes.CUnits
{
    public class Complete:ResponseBase
    {
        public CompleteOutputResult Data { get; set; } 
    }

    public class CompleteOutputResult:Responses.Tasks.Pipettes.CompleteOutputResult
    {
    }
}