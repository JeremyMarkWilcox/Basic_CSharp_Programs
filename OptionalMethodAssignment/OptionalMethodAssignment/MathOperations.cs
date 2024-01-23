using System;
using System.Collections.Generic;
using System.Text;

namespace OptionalMethodAssignment
{
    class MathOperations
    {
        public int PerformMathOperation(int firstNumber, int secondNumber = 10)
        {
            // Example: Addition operation
            int result = firstNumber + secondNumber;
            return result;
        }
    }
}
