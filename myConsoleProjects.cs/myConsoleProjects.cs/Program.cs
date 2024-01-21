using System;

namespace myConsoleProjects.cs
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();
            // Console.WriteLine("Hello, " + name + "!");
            //string doubleQuotes = "The use of double quotes\" \"is necessary";
            //Console.WriteLine(doubleQuotes);

            Console.WriteLine("Welcome to Acme Accounting Systems. Remember, we're \"accouting\" on you!");
            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);
            Console.WriteLine(isRaining);

            Console.Read();
        }
    }
}
