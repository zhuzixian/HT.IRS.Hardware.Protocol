using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class SealerMaterialPositions
    {
        static SealerMaterialPositions()
        {
            WellPlate = new MaterialPosition("96孔板", WorkUnit.Sealer, Material.WellPlate, Position.P001);

            MaterialPositions = new[]
            {
                WellPlate,
            };
        }

        public static MaterialPosition WellPlate { get; }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }
    }
}
