using System;
using System.Collections.Generic;

class Program
{
    // CREATIVITY & EXCEEDING REQUIREMENTS:
    // This program exceeds the core requirements in the following way:
    // 1. Scripture Library: Instead of just memorizing one scripture, the program
    //    randomly selects from a library of multiple scriptures. This helps users
    //    practice with different scriptures and provides more variety.
    // 2. Better Word Selection: The program tracks which words have already been
    //    hidden and only selects from unhidden words (stretch requirement).
    //    This prevents the same word from being hidden multiple times in a row.
    // 3. Variable Hiding: The program hides a random number of words (3-5) each
    //    time rather than a fixed amount, making the challenge more dynamic.

    static void Main(string[] args)
    {
        // Create a library of scriptures
        List<Scripture> scriptureLibrary = CreateScriptureLibrary();
        
        // Randomly select a scripture from the library
        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        bool continueProgram = true;

        while (continueProgram)
        {
            // Clear console and display scripture
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            
            // Check if completely hidden
            if (currentScripture.IsCompletelyHidden())
            {
                Console.WriteLine("\n\nCongratulations! You've hidden all the words!");
                continueProgram = false;
                break;
            }

            // Prompt user
            Console.WriteLine("\n\nPress enter to hide more words, or type 'quit' to exit.");
            string userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                continueProgram = false;
            }
            else
            {
                // Hide a random number of words (3-5) for added challenge
                int numbersToHide = random.Next(3, 6);
                currentScripture.HideRandomWords(numbersToHide);
            }
        }
    }

    // Helper method to create a library of scriptures
    static List<Scripture> CreateScriptureLibrary()
    {
        List<Scripture> library = new List<Scripture>();

        // Add various scriptures to practice
        library.Add(new Scripture(
            new Reference("John", 3, 16),
            "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
        ));

        library.Add(new Scripture(
            new Reference("Proverbs", 3, 5, 6),
            "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"
        ));

        library.Add(new Scripture(
            new Reference("Philippians", 4, 13),
            "I can do all this through him who gives me strength"
        ));

        library.Add(new Scripture(
            new Reference("Psalm", 23, 1, 6),
            "The Lord is my shepherd I shall not want He makes me lie down in green pastures He leads me beside quiet waters He refreshes my soul He guides me along the right paths for his names sake"
        ));

        library.Add(new Scripture(
            new Reference("Matthew", 5, 3, 12),
            "Blessed are the poor in spirit for theirs is the kingdom of heaven Blessed are those who mourn for they will be comforted Blessed are the meek for they will inherit the earth"
        ));

        return library;
    }
}
