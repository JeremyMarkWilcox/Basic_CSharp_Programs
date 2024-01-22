using System;
using System.Collections.Generic;

namespace TryCatchAssignment
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 20, 30, 40, 50 };

            bool exitRequested = false;

            do
            {
                Console.Write("\nEnter a number to divide each element in the list by (enter 'exit' to quit): ");
                string userInput = Console.ReadLine();

                if (userInput.ToLower() == "exit")
                {
                    exitRequested = true;
                }
                else
                {
                    try
                    {
                        int divisor = Convert.ToInt32(userInput);

                        // Iterate through each element in the list, divide by the user's input, and display the result
                        Console.WriteLine("\nResults after division:");
                        foreach (int number in numbers)
                        {
                            double result = DivideSafely(number, divisor);
                            Console.WriteLine($"{number} / {divisor} = {result}");
                        }
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine($"\nError: {ex.Message}. Please enter a valid number.");
                    }
                    catch (DivideByZeroException)
                    {
                        Console.WriteLine("\nError: Cannot divide by zero.");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"\nError: {ex.Message}. An unexpected error occurred.");
                    }
                    finally
                    {
                        // This block will be executed whether there is an exception or not
                        Console.WriteLine("\nThis Program has been tested with a try/catch block function.");
                    }
                }
            } while (!exitRequested);

            Console.WriteLine("\nExiting the program.");

        }
        static double DivideSafely(int numerator, int divisor)
        {
            if (divisor == 0)
            {
                // Throw DivideByZeroException to handle division by zero
                throw new DivideByZeroException("\nYou cannot divide any number by zero.");
            }

            // Return the result of the division
            return (double)numerator / divisor;
        }
    }
}
