using System;

namespace OptionalMethodAssignment
{
    class Program
    {
        static void Main()
        {
            MathOperations mathOperations = new MathOperations();

            // Ask the user to input two numbers
            Console.Write("Enter the first number: ");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.Write("Enter the second number (press Enter if not entering): ");
            string secondNumberInput = Console.ReadLine();

            // Call the method with one or two numbers entered
            int result;

            if (string.IsNullOrEmpty(secondNumberInput))
            {
                result = mathOperations.PerformMathOperation(firstNumber);
            }
            else
            {
                int secondNumber = int.Parse(secondNumberInput);
                result = mathOperations.PerformMathOperation(firstNumber, secondNumber);
            }

            // Display the result
            Console.WriteLine("Result: " + result);
        }
    }
}