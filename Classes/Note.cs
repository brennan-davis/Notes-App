namespace ConsoleNoteApp.Classes
{
    public class Note
    {
        public string FileName { get; set; }
        public string Content { get; set; }
        public DateTime FileCreated { get; set; }
        public DateTime LastModified { get; set; }
    }
}
