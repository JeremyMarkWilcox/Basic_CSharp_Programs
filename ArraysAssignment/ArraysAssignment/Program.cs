using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Task 1
        string[] stringArray = { "Apple", "Banana", "Orange", "Grapes" };
        DisplayArrayElement(stringArray, "fruits");

        // Task 2
        int[] intArray = { 10, 20, 30, 40, 50 };
        DisplayArrayElement(intArray, "integers");

        // Task 4
        List<string> stringList = new List<string> { "Red", "Green", "Blue", "Yellow" };
        DisplayListElement(stringList, "colors");

        Console.ReadLine();
    }

    static void DisplayArrayElement(Array array, string arrayName, int index = -1)
    {
        Console.Write($"\nEnter an index to display in the {arrayName} array: ");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex))
        {
            try
            {
                object element = array.GetValue(selectedIndex);
                Console.WriteLine($"Element at index {selectedIndex} in the {arrayName} array: {element}");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine($"Index {selectedIndex} does not exist in the {arrayName} array.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }

    static void DisplayListElement(List<string> list, string listName)
    {
        Console.Write($"\nEnter an index to display in the {listName} list: ");
        if (int.TryParse(Console.ReadLine(), out int selectedIndex))
        {
            if (selectedIndex >= 0 && selectedIndex < list.Count)
            {
                string element = list[selectedIndex];
                Console.WriteLine($"Element at index {selectedIndex} in the {listName} list: {element}");
            }
            else
            {
                Console.WriteLine($"Index {selectedIndex} does not exist in the {listName} list.");
            }
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid index.");
        }
    }
}
