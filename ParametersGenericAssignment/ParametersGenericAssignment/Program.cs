using System;
using System.Collections.Generic;

namespace ParametersGenericAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object with type "string"
            Employee<string> stringEmployee = new Employee<string>();
            stringEmployee.Things = new List<string> { "Wrench", "Hammer", "Screw Driver" };

            // Instantiate an Employee object with type "int"
            Employee<int> intEmployee = new Employee<int>();
            intEmployee.Things = new List<int> { 1, 2, 3, 4, 5 };

            // This foreach loop prints all of the Things/ Tools to the Console
            Console.WriteLine("Tools of the Employee:");
            foreach (var thing in stringEmployee.Things)
            {
                Console.WriteLine(thing);
            }

            Console.WriteLine("\nThe Employee also has five unknown things:");
            foreach (var thing in intEmployee.Things)
            {
                Console.WriteLine(thing);
            }
        }
    }
}
