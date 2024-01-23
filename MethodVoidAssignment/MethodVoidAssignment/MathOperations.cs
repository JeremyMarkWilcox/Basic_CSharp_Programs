using System;
using System.Collections.Generic;
using System.Text;

namespace MethodVoidAssignment
{
    class MathOperations
    {
        // Void method taking two empty integers as parameters
        public void PerformMathOperation(int firstNumber, int secondNumber)
        {
            // Doing a math operation on the first integer (for example, adding 5)
            int result = firstNumber + 5;

            // Displaying the second integer to the screen
            Console.WriteLine($"Result of the math operation: {result}, Displayed Second Number: {secondNumber}");
        }
    }
}