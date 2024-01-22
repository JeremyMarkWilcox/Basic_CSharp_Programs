using System;

namespace IterationAssignment3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loop with "<" operator
            Console.WriteLine("Loop with \"<\" operator:");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Iteration {i + 1}");
            }

            // Loop with "<=" operator
            Console.WriteLine("\nLoop with \"<=\" operator:");
            for (int j = 0; j <= 5; j++)
            {
                Console.WriteLine($"Iteration {j + 1}");
            }
        }
    }
}

