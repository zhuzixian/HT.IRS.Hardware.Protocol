using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class AbUintMaterialPositions
    {
        static AbUintMaterialPositions()
        {
            MultiTubeTray1 = new MaterialPosition("8联条管#1", WorkUnit.AbUnit,
                Material.MultiTubeTray, Position.P001);

            AbReagentTray1 = new MaterialPosition("AB试剂", WorkUnit.AbUnit, 
                Material.AbReagentTray, Position.P001);

            TipsBox1 = new MaterialPosition("枪头盒#1", WorkUnit.AbUnit,
                Material.TipsBox, Position.P001);
            TipsBox2 = new MaterialPosition("枪头盒#2", WorkUnit.AbUnit,
                Material.TipsBox, Position.P002);
            TipsBox3 = new MaterialPosition("枪头盒#3", WorkUnit.AbUnit,
                Material.TipsBox, Position.P003);

            MaterialPositions = new[]
            {
                MultiTubeTray1,

                AbReagentTray1,

                TipsBox1,
                TipsBox2,
                TipsBox3
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition MultiTubeTray1 { get; }

        public static MaterialPosition TipsBox1 { get; }
        public static MaterialPosition TipsBox2 { get; }
        public static MaterialPosition TipsBox3 { get; }

        public static MaterialPosition AbReagentTray1 { get; }
    }
}
