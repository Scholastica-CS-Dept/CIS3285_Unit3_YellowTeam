namespace CIS3285_Unit3Sample_2024.Models
{
    interface IMessageRepository
    {
        IEnumerable<MessageRecord> GetMessagesForRoomID(int roomID);

        void AddMessageToRoom(int roomID, string authorName, string text);

    }
}
