using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class DUintMaterialPositions
    {
        static DUintMaterialPositions()
        {
            MultiTubeTray = new MaterialPosition("8联条管", WorkUnit.DUnit, Material.MultiTubeTray, Position.P001);

            WellPlateTray = new MaterialPosition("孔板", WorkUnit.DUnit, Material.WellPlate, Position.P001);
            CacheWellPlateTray = new MaterialPosition("暂存区", WorkUnit.DUnit, Material.WellPlate, Position.P001);

            DiscardTipsBox = new MaterialPosition("废枪头盒", WorkUnit.DUnit, Material.TipsBox, Position.P001);
            TipsBox = new MaterialPosition("枪头盒", WorkUnit.DUnit, Material.TipsBox, Position.P002);

            MaterialPositions = new[]
            {
                MultiTubeTray,
                WellPlateTray,
                TipsBox,
                DiscardTipsBox
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition WellPlateTray { get; }
        public static MaterialPosition CacheWellPlateTray { get; }

        public static MaterialPosition TipsBox { get; }
        public static MaterialPosition DiscardTipsBox { get; }

        public static MaterialPosition MultiTubeTray { get; }
    }
}
