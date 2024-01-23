using System;
using System.Collections.Generic;
using System.Text;

namespace ClassExerciseManipulate
{
    class MyClass
    {
        // Create a void method that outputs an integer
        public int DivideByTwo(int input)
        {
            return input / 2;
        }

        // Create a method with output parameters
        public void OutputParametersExample(int input, out int output1, out int output2)
        {
            output1 = input * 2;
            output2 = input * 2;
        }

        // Overload a method (Example: Overloading DivideByTwo) the user will never know our pain
        public double DivideByTwo(double input)
        {
            return input / 2;
        }

        // Declare a class to be static
        public static void StaticMethod()
        {
            Console.WriteLine("This is a static method.");
        }
    }
}

