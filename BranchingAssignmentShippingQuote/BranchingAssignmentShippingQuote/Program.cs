using System;

namespace BranchingAssignmentShippingQuote
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt user for package weight
            Console.Write("Please enter the weight of the package: ");
            double weight = double.Parse(Console.ReadLine());

            // Check if weight is too heavy
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; 
            }

            // Prompt user for package dimensions
            Console.Write("Please enter the package width: ");
            double width = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package height: ");
            double height = double.Parse(Console.ReadLine());

            Console.Write("Please enter the package length: ");
            double length = double.Parse(Console.ReadLine());

            // Function that Calculates the dimension's total
            double dimensionsTotal = width + height + length;

            // Check if dimensions are too big
            if (dimensionsTotal > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; 
            }

            // Calculate the customers quote
            double quote = (width * height * length * weight) / 100; //Max integer result is $2094.75

            
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
            Console.WriteLine("Thank you!");
        }
    }
}

