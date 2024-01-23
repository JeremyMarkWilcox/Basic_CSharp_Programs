using System;

namespace OperatorOverloadAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creating the objects Employee 1- 3

            Employee employee1 = new Employee { Id = 1 };
            Employee employee2 = new Employee { Id = 2 };
            Employee employee3 = new Employee { Id = 1 };

            // Testing the overloaded operators by displaying it in the output.
            // A very simple write up of them side by side for ease
            Console.WriteLine($"employee1 == employee2: {employee1 == employee2}"); // Should be False
            Console.WriteLine($"employee1 != employee2: {employee1 != employee2}"); // Should be True

            Console.WriteLine($"employee1 == employee3: {employee1 == employee3}"); // Should be True
            Console.WriteLine($"employee1 != employee3: {employee1 != employee3}"); // Should be False
        }
    }
}
