// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting numerical data in .NET

int[] quarters = {1,2,3,4};
int[] sales = {100000, 150000, 200000, 225000};
double[] intlMixPct = {.386, .413, .421, .457};
int val1 = 1234;
decimal val2 = 1234.5678m;

// TODO: Specifying Numerical formatting
// General format is {index[,alignment]:[format]}
// Common types are N (Number), G (General), F (Fixed-point), 
// E (Exponential), D (Decimal), P (Percent), X (Hexadecimal),
// C (Currency in local format)

Console.WriteLine("Sales by Quarter:");
Console.WriteLine("{0,-10}{1,10}{2,10}{3,10}", quarters[0], quarters[1], quarters[2], quarters[3]);
Console.WriteLine("{0,-10:N0}{1,10:N0}{2,10:N0}{3,10:N0}", sales[0], sales[1], sales[2], sales[3]);
Console.WriteLine("International Sales:");
Console.WriteLine("{0,-10:P2}{1,10:P2}{2,10:P2}{3,10:P2}", intlMixPct[0], intlMixPct[1], intlMixPct[2], intlMixPct[3]);
Console.WriteLine("Values:");
Console.WriteLine("{0,-10:D}{1,10:D}", val1, val1);
Console.WriteLine("{0,-10:N2}{1,10:N2}", val2, val2);

// TODO: Add a number after the format to specify precision
Console.WriteLine("{0,-10:N2}{1,10:N2}", val2, val2);

// TODO: Formatting with alignment and spacing
Console.WriteLine("Sales by Quarter:");
Console.WriteLine($"{quarters[0]} {quarters[1]} {quarters[2]} {quarters[3]}");
Console.WriteLine($"{sales[0]} {sales[1]} {sales[2]} {sales[3]}");
Console.WriteLine("International Sales:");
Console.WriteLine($"{intlMixPct[0]} {intlMixPct[1]} {intlMixPct[2]} {intlMixPct[3]}");
