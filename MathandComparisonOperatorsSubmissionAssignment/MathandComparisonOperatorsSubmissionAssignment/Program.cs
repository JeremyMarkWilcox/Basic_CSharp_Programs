using System;

namespace MathandComparisonOperatorsSubmissionAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prints Program Title
            Console.WriteLine("\nAnonymous Income Comparison Program");

            // Person 1 Details
            Console.WriteLine("\nPerson 1");
            Console.Write("\nHourly Rate? ");
            double hourlyRate1 = GetHourlyRate(Console.ReadLine());

            Console.Write("Hours worked per week? ");
            double hoursWorkedPerWeek1 = GetHoursWorked(Console.ReadLine());

            // Person 2 Details
            Console.WriteLine("\nPerson 2");
            Console.Write("Hourly Rate? ");
            double hourlyRate2 = GetHourlyRate(Console.ReadLine());

            Console.Write("\nHours worked per week? ");
            double hoursWorkedPerWeek2 = GetHoursWorked(Console.ReadLine());

            // Calculate Annual Salaries
            double annualSalary1 = hourlyRate1 * hoursWorkedPerWeek1 * 52;
            double annualSalary2 = hourlyRate2 * hoursWorkedPerWeek2 * 52;

            // Print Annual Salaries, C returns the number as money/ $
            Console.WriteLine($"\nAnnual salary of Person 1: {annualSalary1:C}");
            Console.WriteLine($"\nAnnual salary of Person 2: {annualSalary2:C}");

            // Compare Their Salaries
            bool person1MakesMore = annualSalary1 > annualSalary2;
            Console.WriteLine($"\nDoes Person 1 make more money than Person 2? {person1MakesMore}");

            Console.ReadLine();
        }

        static double GetHourlyRate(string input)
        {
            // Remove '$' if present, I think it is much more functional to accept an '$' rather than an error
            if (input.StartsWith("$"))
            {
                input = input.Substring(1);
            }

            // Try to parse as decimal
            if (decimal.TryParse(input, out decimal result))
            {
                return (double)result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                return GetHourlyRate(Console.ReadLine());
            }
        }

        static double GetHoursWorked(string input)
        {
            // Try to parse as decimal
            if (decimal.TryParse(input, out decimal result))
            {
                return (double)result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid numeric value.");
                return GetHoursWorked(Console.ReadLine());
            }
        }
    }
}
