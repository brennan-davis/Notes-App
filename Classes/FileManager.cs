namespace ConsoleNoteApp.Classes
{
    public static class FileManager
    {
        
        public static void GetNote()
        {
            string path = @"..\..\..\Notes\TextFile1.txt";
            StreamReader reader = new StreamReader(path);
            string line = reader.ReadLine();
            Console.WriteLine(line);
        }
    }
}
