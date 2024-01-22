using System;
using System.Collections.Generic;
namespace iteration
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] testScores = { 98, 99, 85, 82, 34, 91, 90, 94 };

            //for (int i = 0; i < testScores.Length; i++)
            //{
            //    if (testScores[i] > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + testScores[i]);
            //    }
            //}
            //Console.ReadLine();

            //string[] names = { "Jeremy", "Jeremiah", "Zachariah", "Joshua" };

            //for (int j = 0; j < names.Length; j++)
            //{

            //    Console.WriteLine(names[j]); // If you want to see them all print out

            //    ////if (names[j] == "Jeremy")
            //    //{
            //    //    Console.WriteLine(names[j]);

            //    //}
            //}
            //Console.ReadLine();


            //List<int> testScores = new List<int>();
            //testScores.Add(98);
            //testScores.Add(99);
            //testScores.Add(81);
            //testScores.Add(72);
            //testScores.Add(70);

            //foreach (int score in testScores)
            //{
            //    if (score > 85)
            //    {
            //        Console.WriteLine("Passing test score: " + score);
            //    }
            //}
            //Console.ReadLine();

            //List<string> names = new List<string>() { "Crystal", "Amy", "Erin", "Lynda" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name); // To see all items on the list

            //    //if (name == "Amy")
            //    //{
            //    //    Console.WriteLine(name);
            //    //}
            //}
            //Console.ReadLine();

            List<int> testScores = new List<int>() { 98, 99, 12, 74, 23, 99 };
            List<int> passingScores = new List<int>();

            foreach (int score in testScores)
            {
                if (score > 85)
                {
                    passingScores.Add(score); // counts the total of passing scores
                }
            }

            Console.WriteLine(passingScores.Count);
            Console.ReadLine();




        }
    }
}
