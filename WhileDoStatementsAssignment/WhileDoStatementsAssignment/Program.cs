using System;

namespace WhileDoStatementsAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            const int maxAttempts = 3;
            int attempts = 0;

            // Boolean comparison using a while statement for a password
            Console.WriteLine("Boolean comparison using a while statement:");

            string correctPassword = "Secret123";
            // Limited attempts
            while (attempts < maxAttempts)
            {
                Console.Write("Enter the password: ");
                string userInputWhile = Console.ReadLine();

                if (userInputWhile == correctPassword)
                {
                    Console.WriteLine("Password correct. Access granted.");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect password. Try again.");
                    attempts++;
                }
            }

            Console.WriteLine("\n");



            // Boolean comparison using a do-while statement Guess the Number
            Console.WriteLine("Guess the Secret Number Game (using do-while):");

            int secretNumberDoWhile = new Random().Next(1, 101); // Generate a random number between 1 and 100
            int attemptsDoWhile = 0;

            do
            {
                Console.Write("Guess the secret number (between 1 and 100): ");
                    int userGuessDoWhile;

                if (int.TryParse(Console.ReadLine(), out userGuessDoWhile))
                {
                    if (userGuessDoWhile == secretNumberDoWhile)
                    {
                        Console.WriteLine("Congratulations! You guessed the secret number.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect guess. Try again.");
                        attemptsDoWhile++;
                        if (attemptsDoWhile < maxAttempts)
                        {
                            Console.WriteLine($"Remaining attempts: {maxAttempts - attemptsDoWhile}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                }

            } while (attemptsDoWhile < maxAttempts);

            Console.ReadLine();
        }
    }
}