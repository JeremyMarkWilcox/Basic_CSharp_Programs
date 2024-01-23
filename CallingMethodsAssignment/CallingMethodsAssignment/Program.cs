using System;

namespace CallingMethodsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number for math operations:");
            int userInput = Convert.ToInt32(Console.ReadLine());

            MathOperations mathOps = new MathOperations();

            // Call each method and display the result
            int resultAddOne = mathOps.AddOne(userInput);
            Console.WriteLine($"Result after adding one: {resultAddOne}");

            int resultSquared = mathOps.Squared(userInput);
            Console.WriteLine($"Result after squaring: {resultSquared}");

            int resultDouble = mathOps.Double(userInput);
            Console.WriteLine($"Result after doubling: {resultDouble}");
        }
    }
}
