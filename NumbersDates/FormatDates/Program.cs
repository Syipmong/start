// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for formatting date information

// Define a date
DateTime AprFools = new DateTime(2025, 4, 1, 13, 23, 30);

// TODO: 'd' Short date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine("Short date: {0:d}", AprFools);


// TODO: 'D' Full date: mm/dd/yyyy (or dd/mm depending on locale)
Console.WriteLine("Full date: {0:D}", AprFools);


// TODO: 'f' Full date, short time
Console.WriteLine("Full date, short time: {0:f}", AprFools);


// TODO: 'F' Full date, long time
Console.WriteLine("Full date, long time: {0:F}", AprFools);


// TODO: 'g' General date and time


// TODO: 'G' General date and time


// TODO: Format using a specific CultureInfo


// TODO: Defining custom date and time formats
