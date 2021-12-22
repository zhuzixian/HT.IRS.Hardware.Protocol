using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class AbUintMaterialPositions
    {
        static AbUintMaterialPositions()
        {
            MultiTubeTray1 = new MaterialPosition("8联条管", WorkUnit.AbUnit,
                Material.MultiTubeTray, Position.P001);

            AbReagentTray1 = new MaterialPosition("AB试剂", WorkUnit.AbUnit, 
                Material.AbReagentTray, Position.P001);

            DiscardTipsBox = new MaterialPosition("废枪头盒", WorkUnit.AbUnit,
                Material.TipsBox, Position.P001);
            TipsBoxA = new MaterialPosition("枪头盒A", WorkUnit.AbUnit,
                Material.TipsBox, Position.P002);
            TipsBoxB = new MaterialPosition("枪头盒B", WorkUnit.AbUnit,
                Material.TipsBox, Position.P003);

            MaterialPositions = new[]
            {
                MultiTubeTray1,

                AbReagentTray1,

                TipsBoxA,
                TipsBoxB,
                DiscardTipsBox,
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition MultiTubeTray1 { get; }

        public static MaterialPosition DiscardTipsBox { get; }
        public static MaterialPosition TipsBoxA { get; }
        public static MaterialPosition TipsBoxB { get; }

        public static MaterialPosition AbReagentTray1 { get; }
    }
}
