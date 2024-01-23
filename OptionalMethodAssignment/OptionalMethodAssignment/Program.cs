using System;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            // Ask the user to input the first number
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            // Ask the user to input the second number (optional)
            Console.Write("Enter the second number (press Enter to skip): ");
            string secondNumberInput = Console.ReadLine();

            // Parse the second number if provided, otherwise use the default value (10)
            int? secondNumber = string.IsNullOrEmpty(secondNumberInput) ? (int?)null : int.Parse(secondNumberInput);

            // Call the method with one or two numbers entered
            int result = mathOperations.PerformMathOperation(firstNumber, secondNumber);

            // Display the result
            Console.WriteLine($"Result of the math operation: {result}");
        }
    }
}
