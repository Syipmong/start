// Application Programming .NET Programming with C# by Abdullahi Tijjani

// String Interpolation is a feature that enables the easy insertion of data
// and expression values into a string variable

int a = 100;
float b = 250.0f;
string c = "CSharp";

// String output the old way - using placeholders
Console.WriteLine("The values are {0}, {1} and {2}", a, b, c);

// TODO: Using string interpolation, the code is much easier to read
Console.WriteLine($"The values are {a}, {b} and {c}");



// TODO: Interpolated strings can contain expressions as well
Console.WriteLine($"The sum of {a} and {b} is {a + b}");



// TODO: Complex objects can be embedded in strings this way as well
Console.WriteLine($"The object is {new { Name = "John", Age = 25 }}");


