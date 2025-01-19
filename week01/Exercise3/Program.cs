using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the Guess My Number game!");

        string playAgain = "yes";

        // Main game loop
        while (playAgain.ToLower() == "yes")
        {
            // Step 1: Generate a random magic number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            // Step 2: Initialize variables
            int userGuess = 0;
            int guessCount = 0; // Track number of guesses

            Console.WriteLine("I have picked a magic number between 1 and 100. Try to guess it!");

            // Step 3: Loop until the user guesses the magic number
            while (userGuess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string input = Console.ReadLine();

                guessCount++; // Increment the guess counter

                // Step 4: Compare the guess to the magic number
                if (userGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                }
                else if (userGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine($"You guessed it! It took you {guessCount} guesses.");
                }
            
            }

            // Step 5: Ask the user if they want to play again
            Console.Write("Do you want to play again? (yes/no): ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("Thanks for playing! Goodbye!");
    }
}
