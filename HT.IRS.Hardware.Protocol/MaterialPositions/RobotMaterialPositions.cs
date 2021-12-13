using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class RobotMaterialPositions
    {
        static RobotMaterialPositions()
        {
            MultiTubeTray1 = new MaterialPosition("8联条管#1", WorkUnit.Robots, 
                Material.MultiTubeTray, Position.P001);
            MultiTubeTray2 = new MaterialPosition("8联条管#2", WorkUnit.Robots, 
                Material.MultiTubeTray, Position.P002);

            AbReagentTray1 = new MaterialPosition("AB试剂#1", WorkUnit.Robots, 
                Material.AbReagentTray, Position.P001);
            AbReagentTray2 = new MaterialPosition("AB试剂#2", WorkUnit.Robots, 
                Material.AbReagentTray, Position.P002);

            WellPlate1 = new MaterialPosition("96孔板#1", WorkUnit.Robots,
                Material.WellPlate, Position.P001);
            WellPlate2 = new MaterialPosition("96孔板#2", WorkUnit.Robots,
                Material.WellPlate, Position.P002);
            WellPlate3 = new MaterialPosition("96孔板#3", WorkUnit.Robots,
                Material.WellPlate, Position.P003);

            SampleTray1 = new MaterialPosition("样本#1", WorkUnit.Robots,
                Material.SampleTray, Position.P001);
            SampleTray2 = new MaterialPosition("样本#2", WorkUnit.Robots,
                Material.SampleTray, Position.P002);

            TipsBox1 = new MaterialPosition("枪头盒#1", WorkUnit.Robots,
                Material.TipsBox, Position.P001);
            TipsBox2 = new MaterialPosition("枪头盒#2", WorkUnit.Robots,
                Material.TipsBox, Position.P002);
            TipsBox3 = new MaterialPosition("枪头盒#3", WorkUnit.Robots,
                Material.TipsBox, Position.P003);
            TipsBox4 = new MaterialPosition("枪头盒#4", WorkUnit.Robots,
                Material.TipsBox, Position.P004);
            TipsBox5 = new MaterialPosition("枪头盒#5", WorkUnit.Robots,
                Material.TipsBox, Position.P005);

            MaterialPositions = new[]
            {
                MultiTubeTray1,
                MultiTubeTray2,

                AbReagentTray1,
                AbReagentTray2,

                WellPlate1,
                WellPlate2,
                WellPlate3,

                SampleTray1,
                SampleTray2,

                TipsBox1,
                TipsBox2,
                TipsBox3,
                TipsBox4,
                TipsBox5
            };
        }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }

        public static MaterialPosition MultiTubeTray1 { get; }
        public static MaterialPosition MultiTubeTray2 { get; }
        public static MaterialPosition AbReagentTray1 { get; }
        public static MaterialPosition AbReagentTray2 { get; }
        public static MaterialPosition WellPlate1 { get; }
        public static MaterialPosition WellPlate2 { get; }
        public static MaterialPosition WellPlate3 { get; }
        public static MaterialPosition SampleTray1 { get; }
        public static MaterialPosition SampleTray2 { get; }
        public static MaterialPosition TipsBox1 { get; }
        public static MaterialPosition TipsBox2 { get; }
        public static MaterialPosition TipsBox3 { get; }
        public static MaterialPosition TipsBox4 { get; }
        public static MaterialPosition TipsBox5 { get; }
        
    }
}
