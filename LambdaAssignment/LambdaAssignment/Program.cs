using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdaAssignment
{  
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of employees
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, FirstName = "John", LastName = "Doe" },
                new Employee { Id = 2, FirstName = "Jane", LastName = "Smith" },
                new Employee { Id = 3, FirstName = "Joe", LastName = "Johnson" },
                new Employee { Id = 4, FirstName = "Alice", LastName = "Jones" },
                new Employee { Id = 5, FirstName = "Bob", LastName = "Brown" },
                new Employee { Id = 6, FirstName = "Joe", LastName = "Williams" },
                new Employee { Id = 7, FirstName = "Eva", LastName = "White" },
                new Employee { Id = 8, FirstName = "Sam", LastName = "Black" },
                new Employee { Id = 9, FirstName = "Cathy", LastName = "Green" },
                new Employee { Id = 10, FirstName = "David", LastName = "Miller" }
            };

            // Using foreach loop to create a list of employees with the first name "Joe"
            List<Employee> joesForeach = new List<Employee>();
            foreach (var employee in employees)
            {
                if (employee.FirstName == "Joe")
                {
                    joesForeach.Add(employee);
                }
            }

            // Using lambda expression to create a list of employees with the first name "Joe"
            List<Employee> joesLambda = employees.Where(employee => employee.FirstName == "Joe").ToList();

            // Using lambda expression to create a list of employees with Id greater than 5
            List<Employee> idGreaterThan5 = employees.Where(employee => employee.Id > 5).ToList();

            // Displaying the results
            Console.WriteLine("Employees with the first name 'Joe' (foreach):");
            DisplayEmployees(joesForeach);

            Console.WriteLine("\nEmployees with the first name 'Joe' (lambda):");
            DisplayEmployees(joesLambda);

            Console.WriteLine("\nEmployees with Id greater than 5 (lambda):");
            DisplayEmployees(idGreaterThan5);
        }

        static void DisplayEmployees(List<Employee> employees)
        {
            foreach (var employee in employees)
            {
                Console.WriteLine($"Id: {employee.Id}, Name: {employee.FirstName} {employee.LastName}");
            }
        }
    }
}
