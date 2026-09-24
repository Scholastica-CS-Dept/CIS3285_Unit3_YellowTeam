namespace CIS3285_Unit3Sample_2024.Models
{
    public class RoomRecord
    {
        // Changes Sprint 1 -- I want to create records for each room -- Nick Rasanen
        public RoomRecord(string name, int roomId)
        {
            Name = name;
            RoomId1 = roomId;
        }

        int RoomId;
        public int RoomId1 { get => RoomId; set => RoomId = value; }

        public string Name
        {
            get;
            private set;
        }
    }
}
