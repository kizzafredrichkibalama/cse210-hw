using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Adjusted prompts to exactly match the requirement (lowercase, space)
        Console.Write("What is your first name? ");
        string firstName = Console.ReadLine();
        
        Console.Write("What is your last name? ");
        string lastName = Console.ReadLine();

        // 2. Added a blank line to match the exact spacing
        Console.WriteLine();

        // 3. Adjusted the output string to perfectly match the "Bond, James Bond" style
        Console.WriteLine($"Your name is {lastName}, {firstName} {lastName}.");
    }
}