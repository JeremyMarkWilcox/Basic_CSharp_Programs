using System;

namespace MainMethodAssignment
{
    class MathOperations
    {
        public int PerformOperation(int number)
        {
            // Example: Addition operation
            int result = number + 10;
            return result;
        }

        public int PerformOperation(decimal decimalNumber)
        {
            // Example: Multiplication operation
            int result = (int)(decimalNumber * 5);
            return result;
        }

        public int PerformOperation(string input)
        {
            // Example: Convert to integer and perform division
            if (int.TryParse(input, out int number))
            {
                int result = number / 2;
                return result;
            }
            else
            {
                Console.WriteLine("Invalid input. Please provide a valid integer string.");
                return 0;
            }
        }
    }
}
