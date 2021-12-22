﻿namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Tasks.Pipettes.DUnits
{
    public class CompleteResponsePackage : ResponsePackageBase<Data.Responses.Tasks.Pipettes.DUnits.CompleteResponseData>
    {
        public CompleteResponsePackage(ushort sequenceNo, string data) 
            : base(APIs.Tasks.Complete, sequenceNo, data)
        {
        }

        public CompleteResponsePackage(ushort sequenceNo, Data.Responses.Tasks.Pipettes.DUnits.CompleteResponseData data) 
            : base(APIs.Tasks.Complete, sequenceNo, data) 
        {
        }
    }
}
