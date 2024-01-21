using System;

namespace BooleanLogicCarInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            // Questions
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine(); 

            Console.WriteLine("Have you ever had a DUI? (true/false)");
            bool hasDUI = bool.Parse(Console.ReadLine());

            Console.WriteLine(); 

            Console.WriteLine("How many speeding tickets do you have?");
            int speedingTickets = int.Parse(Console.ReadLine());

            Console.WriteLine(); 

            // Check Qualifications
            bool isOver15 = age > 15;
            bool noDUI = !hasDUI;
            bool notTooManySpeedingTickets = speedingTickets <= 3;

            // Determine Qualifications
            bool isQualified = isOver15 && noDUI && notTooManySpeedingTickets;

           
            Console.WriteLine();

            // Print Results 
            Console.WriteLine("Results:");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"DUI: {hasDUI}");
            Console.WriteLine($"Speeding Tickets: {speedingTickets}");

            Console.WriteLine(); 

            // Print Qualification Result
            Console.WriteLine($"Qualified? {isQualified}");
        }
    }
}
