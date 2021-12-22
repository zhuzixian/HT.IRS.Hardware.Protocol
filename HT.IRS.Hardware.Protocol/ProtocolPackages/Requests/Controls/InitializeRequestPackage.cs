using System;
using HT.IRS.Hardware.Protocol.Data.Requests.Controls;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Requests.Controls
{
    public class InitializeRequestPackage:RequestPackageBase
    {
        public InitializeRequestPackage(string data = default):base(APIs.Controls.Initialize)
        {
            Data = data;
        }

        public InitializeRequestPackage(InitializeRequestData data = default) : base(APIs.Controls.Initialize)
        {
            if (data != default)
            {
                Data = Serialize(data);
            }
        }
    }
}
