using System;

namespace DateTimeAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Current time
            Console.WriteLine($"\nCurrent Date and Time: {DateTime.Now}");
            DateTime currentDateTime = DateTime.Now;

            // Prompt User for the hours
            Console.WriteLine("\nPlease enter the number of hours until you are going to bed:");

            // Read user input as a string
            string hoursToAddString = Console.ReadLine();

            // Convert user input to int
            if (int.TryParse(hoursToAddString, out int hoursToAdd))
            {
                // Add hours to the current date and time
                DateTime newDateTime = currentDateTime.AddHours(hoursToAdd);

                Console.WriteLine($"\nYou're going to bed on {newDateTime}. It will be in {hoursToAdd} hours.");
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number of hours.");
            }

            Console.ReadLine();
        }
    }
}
