using System;

namespace StructureAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an object of data type Number and initialize it with an amount, might as well be decimal that represents money
            Number myNumber = new Number(42.56m);

            // Print the amount to the console
            Console.WriteLine("Amount: " + myNumber.Amount);
        }
    }
}

