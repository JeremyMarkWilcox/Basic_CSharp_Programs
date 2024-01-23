using System;

namespace AbstractAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate an Employee object
            Employee employee = new Employee
            {
                FirstName = "Sample",
                LastName = "Student"
            };

            // Call the SayName() method on the object
            employee.SayName();

            // Keep the console window open
            Console.ReadLine();
        }
    }
}