// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Working with file information

// Make sure the example file exists
const string filename = "TestFile.txt";

if (!File.Exists(filename)) {
    using (StreamWriter sw = File.CreateText(filename)) {
        sw.WriteLine("This is a text file.");
    }
}

// TODO: Get some information about the file

FileInfo fileInfo = new FileInfo(filename);
Console.WriteLine($"File name: {fileInfo.Name}");
Console.WriteLine($"Creation time: {fileInfo.CreationTime}");
Console.WriteLine($"Last Accessed: {fileInfo.LastAccessTime}");
Console.WriteLine($"Last Modified: {fileInfo.LastWriteTime}");


// TODO: We can also get general information using a FileInfo 

Console.WriteLine($"File size: {fileInfo.Length} bytes");
Console.WriteLine($"File attributes: {fileInfo.Attributes}");



// TODO: File information can also be manipulated

File.SetAttributes(filename,FileAttributes.ReadOnly);
Console.WriteLine(fileInfo.Attributes);


//exception handling

try
{
    File.SetAttributes(filename, FileAttributes.Normal);
    Console.WriteLine("File attributes set to normal");
}
catch (Exception e)
{
    Console.WriteLine($"An error occurred: {e.Message}");
}