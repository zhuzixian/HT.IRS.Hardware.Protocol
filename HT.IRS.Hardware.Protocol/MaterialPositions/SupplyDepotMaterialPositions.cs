using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public static class SupplyDepotMaterialPositions
    {
        static SupplyDepotMaterialPositions()
        {
            SampleTray1 = new MaterialPosition("样本托架#1", WorkUnit.SupplyDepot, Material.SampleTray, Position.P101);
            SampleTray2 = new MaterialPosition("样本托架#2", WorkUnit.SupplyDepot, Material.SampleTray, Position.P102);

            TipsBox1 = new MaterialPosition("枪头盒#1", WorkUnit.SupplyDepot, Material.TipsBox, Position.P101);
            TipsBox2 = new MaterialPosition("枪头盒#2", WorkUnit.SupplyDepot, Material.TipsBox, Position.P102);
            TipsBox3 = new MaterialPosition("枪头盒#3", WorkUnit.SupplyDepot, Material.TipsBox, Position.P103);

            WellPlate1 = new MaterialPosition("96孔板#1", WorkUnit.SupplyDepot, Material.WellPlate, Position.P101);
            WellPlate2 = new MaterialPosition("96孔板#2", WorkUnit.SupplyDepot, Material.WellPlate, Position.P102);
            WellPlate3 = new MaterialPosition("96孔板#3", WorkUnit.SupplyDepot, Material.WellPlate, Position.P103);
            WellPlate4 = new MaterialPosition("96孔板#4", WorkUnit.SupplyDepot, Material.WellPlate, Position.P104);

            MultiTubeTray1 = new MaterialPosition("8联管#1", WorkUnit.SupplyDepot, Material.MultiTubeTray, Position.P101);
            MultiTubeTray2 = new MaterialPosition("8联管#2", WorkUnit.SupplyDepot, Material.MultiTubeTray, Position.P201);

            AbReagentTray1 = new MaterialPosition("AB试剂#1", WorkUnit.SupplyDepot, Material.AbReagentTray, Position.P101);
            AbReagentTray2 = new MaterialPosition("AB试剂#2", WorkUnit.SupplyDepot, Material.AbReagentTray, Position.P201);

            RecycleAbReagentTray = new MaterialPosition("AB试剂#回收", WorkUnit.SupplyDepot, Material.AbReagentTray, Position.P201);
            RecycleSampleTray = new MaterialPosition("样本#回收", WorkUnit.SupplyDepot, Material.SampleTray, Position.P201);
            RecycleWellPlate = new MaterialPosition("96孔板#回收", WorkUnit.SupplyDepot, Material.WellPlate, Position.P201);
                
            MaterialPositions = new[]
            {
                TipsBox1,
                TipsBox2,
                TipsBox3,

                WellPlate1,
                WellPlate2,
                WellPlate3,
                WellPlate4,

                MultiTubeTray1,
                MultiTubeTray2,

                AbReagentTray1,
                AbReagentTray2,

                SampleTray1,
                SampleTray2,

                RecycleAbReagentTray,
                RecycleSampleTray,
                RecycleWellPlate
            };
        }

        public static MaterialPosition TipsBox1 { get; }
        public static MaterialPosition TipsBox2 { get; }
        public static MaterialPosition TipsBox3 { get; }

        public static MaterialPosition SampleTray1 { get; }
        public static MaterialPosition SampleTray2 { get; }

        public static MaterialPosition WellPlate1 { get; }
        public static MaterialPosition WellPlate2 { get; }
        public static MaterialPosition WellPlate3 { get; }
        public static MaterialPosition WellPlate4 { get; }

        public static MaterialPosition MultiTubeTray1 { get; }
        public static MaterialPosition MultiTubeTray2 { get; }

        public static MaterialPosition AbReagentTray1 { get; }
        public static MaterialPosition AbReagentTray2 { get; }


        public static MaterialPosition RecycleAbReagentTray { get; }
        public static MaterialPosition RecycleSampleTray { get;  }
        public static MaterialPosition RecycleWellPlate { get; }

        public static IEnumerable<MaterialPosition> MaterialPositions { get; }
    }
}
