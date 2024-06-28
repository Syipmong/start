// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for parsing numerical data from strings

string[] NumStrs = {"  1 ", " 1.45  ", "-100", "5e+04 "};

int testint;
float testfloat;
bool result;

// TODO: The Parse method attempts to parse a string to a number and
// throws an exception if the parse is unsuccessful
foreach (string str in NumStrs) {

}

// TODO: The TryParse method returns 'true' if the parse is successful
// and 'false' if it is not
foreach (string str in NumStrs) {
    result = int.TryParse(str, out testint);
    if (result) {
        Console.WriteLine($"Parsed {str} as {testint}");
    } else {
        Console.WriteLine($"Failed to parse {str}");
    }
}

