using System.IO;

namespace ConsoleNoteApp.Classes
{
    public static class FileManager
    {
        public static void PreviewNote(Note note)
        {
            Console.WriteLine($"File Name: {note.FileName}\nCreated: {note.FileCreated}\nLast Modified: {note.LastModified}\n-----------\n{note.Content}");
        }

        public static string CreatePath(string FileName)
        {
            string path = @"..\..\..\Notes\" + FileName + ".txt";
            return path;
        }

        public static List<Note> GetNoteFiles()
        {
            List<Note> NoteList = new List<Note>();
            DirectoryInfo dir = new DirectoryInfo(@"..\..\..\Notes\");
            FileInfo[] Files = dir.GetFiles("*.txt");
            foreach (FileInfo file in Files)
            {
                Note note = new Note(file.Name, File.ReadAllText(file.FullName), file.CreationTime,file.LastWriteTime);
                NoteList.Add(note);
            }
            return NoteList;
        }

        public static void DrawNotesTable(List<Note> notes)
        {
            Console.WriteLine(string.Format(@"{0, 3}  {1, -15} | {2, -23} | {3, -23}", "", "Note Title", "File Created", "Last Modified"));
            Console.WriteLine(string.Format(@"{0, 3}  {1, -15} | {2, -23} | {3, -23}", "", "----------", "------------", "-------------"));

            int count = 0;
            foreach (Note note in notes)
            {
                Console.WriteLine(string.Format(@"{0, 3}. {1, -15} | {2, -23} | {3, -23}", ++count, note.FileName, note.FileCreated, note.LastModified));
            }
        }
    }
}
