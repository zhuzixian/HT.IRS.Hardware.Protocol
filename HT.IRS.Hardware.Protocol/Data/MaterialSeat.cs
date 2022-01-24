namespace HT.IRS.Hardware.Protocol.Data
{
    public class MaterialSeat
    {
        public MaterialSeat(int station, string type, string position)
        {
            Type = type;
            Station = station;
            Position = position;
        }

        public string Position { get; private set; }
        public string Type { get; private set; }
        public int Station { get; private set; }
    }
}
