// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Creating and Deleting Directories

const string dirname = "TestDir";

// TODO: Create a Directory if it doesn't already exist
 if (!Directory.Exists(dirname))
    {
        Directory.CreateDirectory(dirname);
    }



// TODO: Get the path for the current directory
string currentDirectory = Directory.GetCurrentDirectory();
Console.WriteLine($"Current directory: {currentDirectory}");


// TODO: Just like with files, you can retrieve info about a directory
DirectoryInfo dirInfo = new DirectoryInfo(dirname);
Console.WriteLine($"Directory exists: {dirInfo.Exists}");



// TODO: Enumerate the contents of directories
Console.WriteLine("Just directories:");
foreach (DirectoryInfo dir in dirInfo.GetDirectories())

Console.WriteLine("---------------");
Console.WriteLine($"Name: {dir.Name}");

Console.WriteLine("Just files:");
foreach (FileInfo file in dirInfo.GetFiles())
{
    Console.WriteLine("---------------");
    Console.WriteLine($"Name: {file.Name}");
    Console.WriteLine($"Size: {file.Length} bytes");
}

Console.WriteLine("---------------");

Console.WriteLine("All directory contents:");
foreach (FileSystemInfo fsInfo in dirInfo.GetFileSystemInfos())
{
    Console.WriteLine("---------------");
    Console.WriteLine($"Name: {fsInfo.Name}");
    Console.WriteLine($"Type: {fsInfo.GetType()}");
}
