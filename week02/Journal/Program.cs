using System;

/*
JOURNAL PROGRAM - W02 Assignment

PROGRAM OVERVIEW:
This program helps users maintain a journal by:
1. Showing daily prompts to help with writer's block
2. Saving responses with dates automatically
3. Allowing users to view, save, and load their journal entries

FEATURES INCLUDED:
✓ Write new entry with random prompt
✓ Display all journal entries
✓ Save journal to file
✓ Load journal from file
✓ Interactive menu system

CREATIVITY/BEYOND REQUIREMENTS:
✓ Added PromptGenerator class for better organization
✓ Included 10 prompts (more than the minimum 5)
✓ Error handling for file operations
✓ Entry count display
✓ Clear, friendly user interface

DESIGN CLASSES:
- Entry: Represents a single journal entry (prompt, response, date)
- Journal: Manages all entries (save, load, display, add)
- PromptGenerator: Provides random prompts to users
- Program: Main menu and user interaction
*/

public class Program
{
    private static Journal _journal = new Journal();
    private static PromptGenerator _promptGenerator = new PromptGenerator();

    public static void Main()
    {
        Console.WriteLine("=====================================");
        Console.WriteLine("   WELCOME TO YOUR JOURNAL PROGRAM");
        Console.WriteLine("=====================================\n");

        // Main menu loop - keeps running until user chooses to exit
        bool running = true;
        while (running)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    WriteEntry();
                    break;
                case "2":
                    DisplayJournal();
                    break;
                case "3":
                    SaveJournal();
                    break;
                case "4":
                    LoadJournal();
                    break;
                case "5":
                    Console.WriteLine("\nThank you for journaling today! Goodbye.\n");
                    running = false;
                    break;
                default:
                    Console.WriteLine("\nInvalid choice. Please select 1-5.\n");
                    break;
            }
        }
    }

    // DisplayMenu - shows the menu options to the user
    private static void DisplayMenu()
    {
        Console.WriteLine("\n===== MAIN MENU =====");
        Console.WriteLine("1. Write a new entry");
        Console.WriteLine("2. Display the journal");
        Console.WriteLine("3. Save the journal to a file");
        Console.WriteLine("4. Load the journal from a file");
        Console.WriteLine("5. Quit");
        Console.WriteLine($"(Entries in journal: {_journal.GetEntryCount()})");
        Console.Write("\nWhat would you like to do? ");
    }

    // WriteEntry - gets a prompt and saves the user's response
    private static void WriteEntry()
    {
        // Get a random prompt
        string prompt = _promptGenerator.GetRandomPrompt();

        Console.WriteLine($"\n--- New Entry ---");
        Console.WriteLine($"Prompt: {prompt}");
        Console.Write("Your response: ");
        string response = Console.ReadLine();

        // Get current date in short format (e.g., "1/15/2025")
        string date = DateTime.Now.ToShortDateString();

        // Create and add the entry
        Entry newEntry = new Entry(prompt, response, date);
        _journal.AddEntry(newEntry);

        Console.WriteLine("\nEntry saved!\n");
    }

    // DisplayJournal - shows all entries in the journal
    private static void DisplayJournal()
    {
        _journal.DisplayAll();
    }

    // SaveJournal - prompts user for filename and saves the journal
    private static void SaveJournal()
    {
        Console.Write("\nWhat is the filename you would like to save to? ");
        string filename = Console.ReadLine();

        _journal.SaveToFile(filename);
    }

    // LoadJournal - prompts user for filename and loads the journal
    private static void LoadJournal()
    {
        Console.Write("\nWhat is the filename you would like to load from? ");
        string filename = Console.ReadLine();

        _journal.LoadFromFile(filename);
    }
}
