using System;
using System.Collections.Generic;

namespace IterationAssignment4
{
    class Program
    {
        static void Main(string[] args)
        {
            // A list of strings where each item in the list is unique.
            List<string> stringList = new List<string>
            {
                "apple",
                "banana",
                "orange",
                "grape",
                "kiwi"
            };

            // Ask the user to input text to search for in the list.
            Console.Write("Enter the name of a fruit to see if we have it in stock: ");
            string searchText = Console.ReadLine();

            bool foundMatch = false;

            // A loop that iterates through the list and then displays the index of the list that contains matching text on the screen.
            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Contains(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    // Add code to the loop that tells a user if they put in text that isn’t in the list.
                    Console.WriteLine($"Match found at index {i}");
                    foundMatch = true;

                    // Add code to the loop that stops it from executing once a match has been found.
                    break;
                }
            }

            // If no match is found, notify the user.
            if (!foundMatch)
            {
                Console.WriteLine("Text not found in the list.");
            }

            // Save and execute your code.
            Console.ReadLine();
        }
    }
}
