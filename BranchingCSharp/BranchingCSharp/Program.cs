using System;

namespace BranchingCSharp
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorite number.";
            Console.WriteLine(result);






            //int roomTemperature1 = 70;

            //Console.WriteLine("Hi, what is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature1 = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature1 == roomTemperature1)
            //{
            //    Console.WriteLine("It is exactly room temperture.");
            //}
            //else if (currentTemperature1 > roomTemperature1)
            //{
            //    Console.WriteLine("It is warmer than room temperture.");
            //}
            //else if (currentTemperature1 < roomTemperature1)
            //{
            //    Console.WriteLine("It is colder than room temperture.");
            //}
            //else
            //{
            //    Console.WriteLine("Something went wrong!");
            //}



            //int currentTemperature = 80;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ?
            //    "It is room temp. " : "It is not room temp.";

            //Console.WriteLine(comparisonResult);


            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}

            //else if (currentTemperature > roomTemperature)
            //    {
            //    Console.WriteLine("It is warmer than room temperature.");
            //}

            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature.");
            //}

            //else
            //{
            //    Console.WriteLine("It is not exactly room temperature.");
            //}

            Console.ReadLine();
        }
    }
}
