using System;

namespace IterationAssignment2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Infinite Loop
            // while (true)
            // {
            //    Console.WriteLine("This is an infinite loop!");
            //}

            // Fix the infinite loop, create an int and create a condition so the loop will end
            int count = 0;
            while (count < 5) // Change the condition to a finite condition
            {
                Console.WriteLine("Executing loop iteration: " + count);
                count++;
            }

            Console.WriteLine("Loop completed!");
        }
    }
}

