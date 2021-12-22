using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class CUintMaterialPositions
    {
        static CUintMaterialPositions()
        {
            WellPlateTray = new MaterialPosition("孔板", WorkUnit.CUnit, Material.WellPlate, Position.P001);
            SampleTray = new MaterialPosition("样本托架", WorkUnit.CUnit, Material.SampleTray, Position.P001);

            DiscardTipsBox = new MaterialPosition("废枪头盒", WorkUnit.CUnit, Material.TipsBox, Position.P001);
            TipsBox = new MaterialPosition("枪头盒", WorkUnit.CUnit, Material.TipsBox, Position.P002);

            MaterialPositions = new[]
            {
                WellPlateTray,
                SampleTray,
                TipsBox,
                DiscardTipsBox
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition WellPlateTray { get; }

        public static MaterialPosition TipsBox { get; }
        public static MaterialPosition DiscardTipsBox { get; }

        public static MaterialPosition SampleTray { get; }
    }
}
