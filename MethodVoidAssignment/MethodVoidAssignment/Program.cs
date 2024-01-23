using System;

namespace MethodVoidAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MathOperations mathOperations = new MathOperations();

            // Call the method in the class, passing in two numbers
            mathOperations.PerformMathOperation(10, 20);

            // Call the method in the class, specifying the parameters by name
            mathOperations.PerformMathOperation(firstNumber: 8, secondNumber: 15);
        }
    }
}