using System;
using System.Collections.Generic;
namespace ArraysandLists
{
    class Program
    {
        static void Main()
        {

            //LISTS, work with any data type

            List<int> inList = new List<int>();
            inList.Add(4);
            inList.Add(10);

            Console.WriteLine(inList[0]);


            


            //// The long way
            //int[] numArray = new int[5];
            //numArray[0] = 5;
            //numArray[1] = 2;
            //numArray[2] = 10;
            //numArray[3] = 200;
            //numArray[4] = 5000;

            //Console.WriteLine(numArray[3]);

            //// Curly Bracket Method, Same Array, Don't have to set the number of indexes this way

            //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000 };

            //Console.WriteLine(numArray1[3]);

            //int[] numArray2 = { 5, 2, 10, 200, 5000 };

            //numArray2[5] = 650;



            Console.ReadLine();




        }
    }
}
