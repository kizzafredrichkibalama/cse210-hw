using System;

namespace Exercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Stretch Challenge: Loop to play the entire game again
            string playAgain = "yes";

            while (playAgain.ToLower() == "yes")
            {
                // Core Requirement 3: Generate a random magic number from 1 to 100
                Random randomGenerator = new Random();
                int magicNumber = randomGenerator.Next(1, 101); // 101 is exclusive

                int guess = -1;
                int guessCount = 0; // Stretch Challenge: Track number of guesses

                Console.WriteLine("I have picked a magic number between 1 and 100.");

                // Core Requirement 2: Loop until the guess matches the magic number
                while (guess != magicNumber)
                {
                    // Core Requirement 1: Ask the user for a guess
                    Console.Write("What is your guess? ");
                    guess = int.Parse(Console.ReadLine());
                    guessCount++;

                    // Core Requirement 1: Determine if higher, lower, or correct
                    if (guess < magicNumber)
                    {
                        Console.WriteLine("Higher");
                    }
                    else if (guess > magicNumber)
                    {
                        Console.WriteLine("Lower");
                    }
                    else
                    {
                        Console.WriteLine("You guessed it!");
                    }
                }

                // Stretch Challenge: Inform the user of their guess count
                Console.WriteLine($"It took you {guessCount} guesses.");

                // Stretch Challenge: Ask to play again
                Console.Write("Do you want to play again (yes/no)? ");
                playAgain = Console.ReadLine();
                Console.WriteLine(); // Prints a blank line for clean spacing between games
            }

            Console.WriteLine("Thank you for playing!");
        }
    }
}
