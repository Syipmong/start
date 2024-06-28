// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Files

using System.Text;

const string filename = "TestFile.txt";

// TODO: Create a new file - this will overwrite any existing file
// Use the "using" construct to automatically close the file stream


// TODO: Determine if a file exists

bool fileExists = File.Exists(filename);
Console.WriteLine($"File exists: {fileExists}");

// lets create the file now
using (FileStream fs = File.Create(filename))
{
    // Add some text to the file
    byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file");
    fs.Write(info, 0, info.Length);
}
