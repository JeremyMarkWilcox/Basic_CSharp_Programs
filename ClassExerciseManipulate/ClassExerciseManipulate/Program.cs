using System;

namespace ClassExerciseManipulate
{
    class Program
    {
        static void Main(string[] args)
        {
            // Instantiate the class
            MyClass myClass = new MyClass();

            // Have the user enter a number
            Console.Write("Enter a number: ");
            if (int.TryParse(Console.ReadLine(), out int userNumber))
            {
                // Call the method on the entered number and display the output
                int result = myClass.DivideByTwo(userNumber);
                Console.WriteLine($"\nResult of dividing {userNumber} by 2: {result}");

                // Call the method with output parameters
                myClass.OutputParametersExample(userNumber, out int outputParam1, out int outputParam2);
                Console.WriteLine($"\nInt Output: {outputParam1}, \nDouble Output: {outputParam2}");
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid number.");
            }
        }
    }
}