// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for parsing dates from strings

// Collection of various date string formats to attempt parsing
string[] sampleDateTimes = {
    "January 1, 2025 9:30 AM",
    "1/1/2025",
    "Jan 1, 2025 7:30PM",
    "Jan 1, 25",
    "1/2025",
    "1/1 7PM",
    "Jan 1 '15",
};

foreach (string datestr in sampleDateTimes) {
    DateTime result;
    // TODO: Use the static class function TryParse to try parsing the dates
    if (DateTime.TryParse(datestr, out result)) {
        Console.WriteLine("Parsed: {0} as {1}", datestr, result);
    } else {
        Console.WriteLine("Failed to parse: {0}", datestr);
    }  
    
}
