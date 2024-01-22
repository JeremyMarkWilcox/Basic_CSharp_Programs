using System;

class Program
{
    static void Main()
    {
        // A one-dimensional array of boy and girl names.
        string[] boyNames = { "James", "Michael", "Ethan" };
        string[] girlNames = { "Emma", "Olivia", "Sophia" };

        // Ask the user to input a last name.
        Console.WriteLine("Enter a last name to see how it sounds with the suggested names:");

        // Get the user's input for the last name.
        string lastName = Console.ReadLine();

        // A loop that iterates through each string in the array and adds the user's text input to the end of each string.
        for (int i = 0; i < boyNames.Length; i++)
        {
            boyNames[i] += " " + lastName;
        }

        for (int i = 0; i < girlNames.Length; i++)
        {
            girlNames[i] += " " + lastName;
        }

        // Create a loop that prints off each string in the array on a separate line.
        Console.WriteLine("\nSuggested Names:");
        for (int i = 0; i < boyNames.Length; i++)
        {
            Console.WriteLine($"1. {boyNames[i]}");
        }

        for (int i = 0; i < girlNames.Length; i++)
        {
            Console.WriteLine($"2. {girlNames[i]}");
        }

        Console.ReadLine();
    }
}

