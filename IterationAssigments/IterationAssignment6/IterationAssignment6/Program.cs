using System;
using System.Collections.Generic;

namespace IterationAssignment6
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "The Legend of Zelda: Breath of the Wild",
                "Super Mario Odyssey",
                "Red Dead Redemption 2",
                "Fortnite",
                "FIFA 22",
                "Minecraft",
                "Overwatch",
                "The Witcher 3: Wild Hunt",
                "Final Fantasy XV",
                "Assassin's Creed Odyssey",
                "Fortnite"
                
            };

            // Create a HashSet to track unique games
            HashSet<string> uniqueGames = new HashSet<string>();

            // Iterate through each game title in the list
            foreach (string gameTitle in videoGames)
            {
                // Check if the game title has already appeared
                if (uniqueGames.Contains(gameTitle))
                {
                    Console.WriteLine($"\n{gameTitle} has already been added to the list of video games.");
                }
                else
                {
                    Console.WriteLine($"{gameTitle} is a new addition to the list of video games.");
                    // Add the game title to the HashSet
                    uniqueGames.Add(gameTitle);
                }
            }
        }
    }
}
