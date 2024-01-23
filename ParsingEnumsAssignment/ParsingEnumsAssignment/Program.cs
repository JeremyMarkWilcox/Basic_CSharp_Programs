using System;

namespace ParsingEnumsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                // Prompt the user to enter the current day of the week
                Console.Write("Enter the current day of the week: ");
                string userInput = Console.ReadLine();

                // Convert the user input to the enum type, when in doubt TryParse it out
                if (Enum.TryParse<DaysOfTheWeek.DaysOfWeek>(userInput, true, out DaysOfTheWeek.DaysOfWeek parsedDay))
                {
                    // Check if the conversion was successful
                    Console.WriteLine($"You entered: {parsedDay}");
                }
                else
                {
                    // Print an error message if the input is not a valid day of the week
                    Console.WriteLine("Please enter an actual day of the week.");
                }
            }
            catch (Exception ex)
            {
                // Handle other exceptions, if any
                Console.WriteLine($"An error occurred: {ex.Message}");
            }
        }
    }
}
