using System;

namespace DailyReportTheTechAcademy
{
    class Program
    {
        static void Main()
        {
            // Print Intro Lines
            Console.WriteLine("\nThe Tech Academy");
            Console.WriteLine("\nStudent Daily Report");

            // Ask and Save Data
            Console.Write("\nWhat is your name? ");
            string studentName = Console.ReadLine();

            Console.Write("\nWhat course are you on? ");
            string currentCourse = Console.ReadLine();

            int currentPageNumber;
            while (true)
            {
                Console.Write("\nWhat page number? ");
                if (int.TryParse(Console.ReadLine(), out currentPageNumber))
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            }

            bool needsHelp;
            while (true)
            {
                Console.Write("\nDo you need help with anything? Please answer \"true\" or \"false\": ");
                if (bool.TryParse(Console.ReadLine(), out needsHelp))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter either \"true\" or \"false\".");
                }
            }

            Console.Write("\nWere there any positive experiences you'd like to share? Please give specifics: ");
            string positiveExperiences = Console.ReadLine();

            Console.Write("\nIs there any other feedback you'd like to provide? Please be specific: ");
            string additionalFeedback = Console.ReadLine();

            double todaysStudyHours;
            while (true)
            {
                Console.Write("\nHow many hours did you study today? ");
                if (double.TryParse(Console.ReadLine(), out todaysStudyHours))
                {
                    break; 
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }
            }

            // Print Closing Message
            Console.WriteLine("\nThank you for your answers. An Instructor will respond to this shortly. Have a great day!");
        }
    }
}
