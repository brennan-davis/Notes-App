namespace ConsoleNoteApp.Classes
{
    public class Note
    {
        public string FileName { get; set; }
        public string? Content { get; set; }
        public DateTime FileCreated { get; set; }
        public DateTime LastModified { get; set; }

        public Note(string fileName, string content, DateTime fileCreated, DateTime lastModified)
        {
            FileName = fileName;
            Content = content;
            FileCreated = fileCreated;
            LastModified = lastModified;
        }

        public Note(string fileName, DateTime fileCreated, DateTime lastModified)
        {
            FileName = fileName;
            FileCreated = fileCreated;
            LastModified = lastModified;
        }
    }
}
