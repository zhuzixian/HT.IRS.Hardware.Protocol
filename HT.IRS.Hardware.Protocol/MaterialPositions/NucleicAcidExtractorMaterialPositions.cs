using System.Collections.Generic;

namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public class NucleicAcidExtractorMaterialPositions
    {
        public NucleicAcidExtractorMaterialPositions(string unitWork)
        {
            TipsBox = new MaterialPosition("枪头盒", unitWork, Material.TipsBox, Position.P001);

            WellPlate1 = new MaterialPosition("96孔板#1", unitWork, Material.WellPlate, Position.P001);
            WellPlate2 = new MaterialPosition("96孔板#2", unitWork, Material.WellPlate, Position.P002);
            WellPlate3 = new MaterialPosition("96孔板#3", unitWork, Material.WellPlate, Position.P003);
            WellPlate4 = new MaterialPosition("96孔板#4", unitWork, Material.WellPlate, Position.P004);


            MaterialPositions = new[]
            {
                TipsBox,
                WellPlate1,
                WellPlate2,
                WellPlate3,
                WellPlate4,
            };
        }

        public MaterialPosition TipsBox { get; }

        public MaterialPosition WellPlate1 { get; }
        public MaterialPosition WellPlate2 { get; }
        public MaterialPosition WellPlate3 { get; }
        public MaterialPosition WellPlate4 { get; }

        public IEnumerable<MaterialPosition> MaterialPositions { get; }
    }
}
