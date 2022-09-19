using ConsoleNoteApp.Classes;

//FileManager.GetNote("TextFile1");

List<Note> notes = FileManager.GetNoteFiles();

FileManager.DrawNotesTable(notes);

FileManager.PreviewNote(notes[0]);