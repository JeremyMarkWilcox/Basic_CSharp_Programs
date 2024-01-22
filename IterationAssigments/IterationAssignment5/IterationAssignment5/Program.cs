using System;
using System.Collections.Generic;

namespace IterationAssignment5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> stringList = new List<string> { "apple", "banana", "orange", "apple", "grape" };

            Console.Write("Enter fruit to search for(apple for the double): ");
            string searchText = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < stringList.Count; i++)
            {
                if (stringList[i].Equals(searchText, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine($"Text found at index {i}");
                    found = true;
                }
            }

            if (!found)
            {
                Console.WriteLine("Text not found in the list.");
            }
        }
    }
}
