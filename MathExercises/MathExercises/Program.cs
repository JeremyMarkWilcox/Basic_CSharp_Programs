using System;

namespace MathExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            // Method to add two numbers
            static int AddNumbers(int a, int b)
            {
                return a + b;
            }

            // Method to subtract two numbers
            static int SubtractNumbers(int a, int b)
            {
                return a - b;
            }

            // Method to multiply two numbers
            static int MultiplyNumbers(int a, int b)
            {
                return a * b;
            }

            // Method to divide two numbers
            static double DivideNumbers(int a, int b)
            {
                // Perform the division as a double to include decimal places in the result
                return (double)a / b;
            }

            // I use Interpolated Strings in the Variables
            // Add two numbers 
            int sum = AddNumbers(5, 3);
            Console.WriteLine($"Sum: {sum}");

            // Subtract two numbers 
            int difference = SubtractNumbers(8, 3);
            Console.WriteLine($"Difference: {difference}");

            // Multiply two numbers 
            int product = MultiplyNumbers(4, 6);
            Console.WriteLine($"Product: {product}");

            // Divide two numbers 
            double quotient = DivideNumbers(9, 2);
            Console.WriteLine($"Quotient: {quotient}");

            string jer = "Jeremy";
            Console.WriteLine("\nI think " + jer + " can actually code some!");

            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine("\nFive plus Ten equals " + total.ToString());
            Console.WriteLine("\n" + combined);

            int difference1 = 10 - 5;
            Console.WriteLine("\nTen minus Five equals " + difference1.ToString());

            int product1 = 10 * 5;
            Console.WriteLine("\n" + product1);

            double quotient1 = 100.0 / 17.0;
            Console.WriteLine("\n" + quotient1);

            int remainder = 11 % 2;
            Console.WriteLine("\n" + remainder);

            bool trueorflase = 12 > 5;
            Console.WriteLine(trueorflase.ToString());

            int roomTemperature = 70;
            int currentTemperature = 70;

            //bool isWarm = currentTemperature >= roomTemperature;
            bool isWarm = currentTemperature == roomTemperature;
            Console.WriteLine(isWarm);

            // 1. Multiply by 50
            Console.Write("Enter a number to multiply by 50: ");
            double input1 = Convert.ToDouble(Console.ReadLine());
            double result1 = input1 * 50;
            Console.WriteLine($"Result: {result1}");

            // 2. Add 25
            Console.Write("Enter a number to add 25 to: ");
            double input2 = Convert.ToDouble(Console.ReadLine());
            double result2 = input2 + 25;
            Console.WriteLine($"Result: {result2}");

            // 3. Divide by 12.5
            Console.Write("Enter a number to divide by 12.5: ");
            double input3 = Convert.ToDouble(Console.ReadLine());
            double result3 = input3 / 12.5;
            Console.WriteLine($"Result: {result3}");

            // 4. Check if greater than 50
            Console.Write("Enter a number to check if it's greater than 50: ");
            double input4 = Convert.ToDouble(Console.ReadLine());
            bool result4 = input4 > 50;
            Console.WriteLine($"Result: {result4}");

            // 5. Divide by 7 and print remainder
            Console.Write("Enter a number to find the remainder when divided by 7: ");
            double input5 = Convert.ToDouble(Console.ReadLine());
            double remainder1 = input5 % 7;
            Console.WriteLine($"Remainder: {remainder}");
















            Console.ReadLine(); // To keep the console window open

        }

        
    }
}

