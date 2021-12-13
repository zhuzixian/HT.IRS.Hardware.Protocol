namespace HT.IRS.Hardware.Protocol.MaterialPositions
{
    public class MaterialPosition
    {
        public MaterialPosition(string name, string station, string type, string position)
        {
            Name = name;
            Type = type;
            Station = station;
            Position = position;
        }

        public string Name { get; private set; }
        public string Position { get; private set; }
        public string Type { get; private set; }
        public string Station { get; private set; }
    }
}
