// See https://aka.ms/new-console-template for more information
// 1. Prompt the user to enter a date or type "exit" to quit the program.
// 2. Parse the entered date and check if it is valid.
// 3. Compare the entered date with the current date to determine if it is in the past, present,
// or future.
// 4. Display the appropriate message based on the comparison.
// 5. Handle invalid date inputs gracefully by showing an error message.
// 6. The program should loop until the user decides to exit.


Console.WriteLine("Hello User!");

while (true)
{
    Console.WriteLine("Please enter a date or type 'exit' to quit the program:");
    string InputDate = Console.ReadLine();
    Console.WriteLine(InputDate);

    if (InputDate.ToLower() == "exit")
    {
        Console.WriteLine("Exiting the program...");
        break;
    }
    else
    {
        DateTime now = DateTime.Now;
        DateTime date;
        if (DateTime.TryParse(InputDate, out date))
        {
            if (date < now)
            {
                Console.WriteLine("The date is in the past.");
                TimeSpan days = now - date;
                Console.WriteLine($"It has been {days.Days} days since the date.");
            }
            else if (date == now)
            {
                Console.WriteLine("The date is today.");
            }
            else
            {
                Console.WriteLine("The date is in the future.");
                TimeSpan days = date - now;
                Console.WriteLine($"There are {days.Days} days left until the date.");
            }
        }
        else
        {
            Console.WriteLine("Invalid date entered. Please try again.");
        }
    }

}