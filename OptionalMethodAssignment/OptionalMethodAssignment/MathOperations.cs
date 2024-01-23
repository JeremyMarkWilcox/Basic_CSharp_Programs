using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalMethodAssignment
{
    public class MathOperations
    {
        public int PerformMathOperation(int firstNumber, int? secondNumber)
        {
            // Perform the math operation using firstNumber and secondNumber
            // Handle the case where secondNumber is null (user skipped entering the second number)

            if (secondNumber.HasValue)
            {
                // Perform operation with two numbers
                return firstNumber + secondNumber.Value; // Change this line as needed
            }
            else
            {
                // Perform operation with only one number
                return firstNumber; // Change this line as needed
            }
        }
    }
}
