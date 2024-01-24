using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace TwentyOneExercise
{
    class Program
    {
        static void Main(string[] args)
        {

           

            Console.WriteLine("Welcome to the Grand Hotel and Casino. Let's start by telling me your name.");
            string playerName = Console.ReadLine();

            Console.WriteLine("\nAnd how much money did your bring today?");

            int bank = GetNumericInput(); 

            Console.WriteLine("\nHello, {0}. Would you like to join a game of 21 right now?", playerName);
            string answer = Console.ReadLine().ToLower();

            if (answer == "yes" || answer == "yeah" || answer == "y" || answer == "ya")
            {
                Player player = new Player(playerName, bank);
                Game game = new TwentyOneGame();
                game += player;
                player.isActivelyPlaying = true;

                while (player.isActivelyPlaying && player.Balance > 0)
                {
                    game.Play();
                }

                game -= player;
                Console.WriteLine("\nThank you for playing!");
            }

            Console.WriteLine("\nFeel free to look around the casino. Bye for now.");
            Console.Read();
        }

        static int GetNumericInput()
        {
            string userInput = Console.ReadLine();

            // Remove non-numeric characters
            string numericInput = new string(userInput.Where(char.IsDigit).ToArray());

            // Convert to integer
            if (int.TryParse(numericInput, out int input))
            {
                return input;
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please enter a valid numeric value.");
                return GetNumericInput(); // Recursively call to get valid input
            }
        }
    }
}

