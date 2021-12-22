using HT.IRS.Hardware.Protocol.Data.Responses.Status;

namespace HT.IRS.Hardware.Protocol.ProtocolPackages.Responses.Status
{
    public class DeviceInfoResponsePackage: ResponsePackageBase<DeviceInfoResponseData>
    {
        public DeviceInfoResponsePackage(ushort sequenceNo, string data)
            :base(APIs.Status.GetDeviceInfos, sequenceNo, data) 
        {
        }

        public DeviceInfoResponsePackage(ushort sequenceNo, DeviceInfoResponseData data) 
            : base(APIs.Status.GetDeviceInfos, sequenceNo, data)
        {
        }
    }
}
