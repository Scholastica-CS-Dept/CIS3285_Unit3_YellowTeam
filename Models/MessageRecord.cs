namespace CIS3285_Unit3Sample_2024.Models
{
    public class MessageRecord
    {
        // Changes Sprint 2 -- I want to send messages populated with the room information -- Nick Rasanen
        public MessageRecord(int roomID, string authorName, string text)
        {
            RoomID = roomID;
            Text = text;
            AuthorName = authorName;
        }

        public int RoomID
        {
            get;
            private set;
        }

        // Changes Sprint 2 -- The string that stores all the message text for the room -- Nick Rasanen
        public string Text
        {
            get;
            private set;
        }

        public string AuthorName
        {
            get;
            private set;
        }
    }
}
