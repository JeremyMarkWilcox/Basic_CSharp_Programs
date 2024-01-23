using System;

namespace MainMethodAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            MathOperations mathOperations = new MathOperations();

            // Example for the first method
            int integerResult = mathOperations.PerformOperation(5);
            Console.WriteLine("Result of integer operation: " + integerResult);

            // Example for the second method
            decimal decimalInput = 7.5m;
            int decimalResult = mathOperations.PerformOperation(decimalInput);
            Console.WriteLine("Result of decimal operation: " + decimalResult);

            // Example for the third method
            string stringInput = "20";
            int stringResult = mathOperations.PerformOperation(stringInput);
            Console.WriteLine("Result of string operation: " + stringResult);
        }
    }
}
