// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Reading and Writing data from and to files

// Make sure the example file exists
const string filename = "TestFile.txt";

// TODO 1: WriteAllText overwrites a file with the given content
if (!File.Exists(filename)) {
    File.WriteAllText(filename, "This is a text file.");
}

// TODO 3: AppendAllText adds text to an existing file
if (File.Exists(filename)) {
    File.AppendAllText(filename, " This is an appended text.");
    }


// TODO 4: A FileStream can be opened and written to until closed
using (FileStream fs = new FileStream(filename, FileMode.Append)) {
    using (StreamWriter sw = new StreamWriter(fs)) {
        sw.WriteLine("This is a line written using a FileStream.");
    }
}


// TODO 2: ReadAllText reads all the content from a file

string fileContent = File.ReadAllText(filename);
Console.WriteLine(fileContent);

