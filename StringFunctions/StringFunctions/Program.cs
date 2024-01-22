using System;
using System.Text; //Need for String Builder

namespace StringFunctions
{
    class Program
    {
        static void Main(string[] args)
        {


            //string name = "Jeremy";
            //string quote = "The man said, \"Hello\", Jeremy. \n Hello on a new line. \n \t Hello on a tab!";
            //Console.WriteLine(quote);

            //string filename = "C\\Users\\Jeremy";
            //Console.WriteLine(filename);
            //string filename1 = @"C\Users\Jeremy";
            //Console.WriteLine(filename1);

            //bool trueOrFalse = name.Contains("s");
            //Console.WriteLine(trueOrFalse); // Correct as false, Jeremy

            //bool trueOrFalse1 = name.EndsWith("s");
            //Console.WriteLine(trueOrFalse1);

            //int length = name.Length;
            //Console.WriteLine(length);

            //string nameUp = name.ToUpper();
            //Console.WriteLine(nameUp);

            //string nameDown = name.ToLower();
            //Console.WriteLine(nameDown);


            // Last declared variable is displayed/ used
            //string name = "Jeremy";
            //name = "Joe";
            //Console.WriteLine(name);


            StringBuilder sb = new StringBuilder();

            sb.Append("My name is Jeremy!");
            sb.Append("For Real DUDE!");
            Console.WriteLine(sb);

            //STRINGS CHALLENGE

            string str1 = "Hello, ";
            string str2 = "world!";
            string str3 = " and Welcome to C#.";
            string concatenatedString = ConcatenateStrings(str1, str2, str3);
            Console.WriteLine("Concatenated String says: " + concatenatedString);
            static string ConcatenateStrings(string str1, string str2, string str3)
            {
                return str1 + str2 + str3;
            }


            string littleMarioString = "I need to grow! ";
            string bigMarioString = ConvertToUppercase(littleMarioString);
            Console.WriteLine(  bigMarioString + "There is a mushroom! (Growing noises)");
            static string ConvertToUppercase(string inputString)
            {
                return inputString.ToUpper();
            }

            StringBuilder paragraphBuilder = BuildParagraph();
            Console.WriteLine("Built Paragraph:\n" + paragraphBuilder.ToString());
            }
        static StringBuilder BuildParagraph()
        {
            StringBuilder paragraphBuilder = new StringBuilder();

            paragraphBuilder.Append("This is the first sentence. ");
            paragraphBuilder.Append("Here comes the second sentence. ");
            paragraphBuilder.Append("And finally, the third sentence.");

            return paragraphBuilder;

            Console.ReadLine();
        }













        

     }
        






        
}


