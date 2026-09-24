namespace CIS3285_Unit3Sample_2024.Models
{
    interface IRoomRepository
    {
        void CreateRoom(string name);

        IEnumerable<RoomRecord> GetAllRooms();
    }
}
