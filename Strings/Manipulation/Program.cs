// Application Programming .NET Programming with C# by Abdullahi Tijjani
// Example file for manipulating string content

string str1 = "The quick brown fox jumps over the lazy dog.";
string str2 = "This is a string";
string str3 = "THIS is a STRING";
string[] strs = {"one", "two", "three", "four"};

// TODO: Length of a string 
Console.WriteLine($"Length of str1: {str1.Length}");
Console.WriteLine($"Length of str2: {str2.Length}");
Console.WriteLine($"Length of str3: {str3.Length}");
Console.WriteLine($"Length of strs: {strs.Length}"); // Length of array



// TODO: Access individual characters
Console.WriteLine($"First character of str1: {str1[0]}");
Console.WriteLine($"Last character of str1: {str1[str1.Length - 1]}");
Console.WriteLine($"First character of str2: {str2[0]}");
Console.WriteLine($"Last character of str2: {str2[str2.Length - 1]}");
Console.WriteLine($"First character of str3: {str3[0]}");
Console.WriteLine($"Last character of str3: {str3[str3.Length - 1]}");
Console.WriteLine($"First character of strs: {strs[0]}");
Console.WriteLine($"Last character of strs: {strs[strs.Length - 1]}");



// TODO: Iterate over a string like any other sequence of values
foreach (char c in str1) {
    Console.Write($"{c} ");
}



// TODO: String Concatenation         
string outstr;
outstr = str1 + " " + str2;
Console.WriteLine(outstr);



// TODO: Joining strings together with Join
string joined = string.Join(", ", strs);
Console.WriteLine(joined);



// TODO: String Comparison


// Equals just returns a regular Boolean
bool isEqual = str2.Equals(str3);
Console.WriteLine($"{isEqual}");

// Compare will perform an ordinal comparison and return:
// < 0 : first string comes before second in sort order
// 0 : first and second strings are same position in sort order
// > 0 : first string comes after the second in sort order
int result = string.Compare(str2, str3);
Console.WriteLine($"{result}");



// TODO: Replacing content
string replaced = str1.Replace("fox", "wolf");
Console.WriteLine(replaced);

