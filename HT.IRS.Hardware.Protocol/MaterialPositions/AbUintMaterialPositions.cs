using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class AbUintMaterialPositions
    {
        static AbUintMaterialPositions()
        {
            MultiTubeTray = new MaterialPosition("8联条管", WorkUnit.AbUnit,
                Material.MultiTubeTray, Position.P001);

            AbReagentTray = new MaterialPosition("AB试剂", WorkUnit.AbUnit, 
                Material.AbReagentTray, Position.P001);

            DiscardTipsBox = new MaterialPosition("废枪头盒", WorkUnit.AbUnit,
                Material.TipsBox, Position.P001);
            TipsBoxA = new MaterialPosition("枪头盒A", WorkUnit.AbUnit,
                Material.TipsBox, Position.P002);
            TipsBoxB = new MaterialPosition("枪头盒B", WorkUnit.AbUnit,
                Material.TipsBox, Position.P003);

            CloseMultiTubeCap = new MaterialPosition("8联联条管托架盖#关", WorkUnit.AbUnit,
                Material.MultiTubeCap, Position.P001);
            OpenMultiTubeCap = new MaterialPosition("8联条管托架盖#开", WorkUnit.AbUnit,
                Material.MultiTubeCap, Position.P002);

            MaterialPositions = new[]
            {
                MultiTubeTray,

                AbReagentTray,

                TipsBoxA,
                TipsBoxB,
                DiscardTipsBox,

                CloseMultiTubeCap,
                OpenMultiTubeCap
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition MultiTubeTray { get; }

        public static MaterialPosition DiscardTipsBox { get; }
        public static MaterialPosition TipsBoxA { get; }
        public static MaterialPosition TipsBoxB { get; }

        public static MaterialPosition AbReagentTray { get; }

        public static MaterialPosition CloseMultiTubeCap { get; }
        public static MaterialPosition OpenMultiTubeCap { get; }
    }
}
