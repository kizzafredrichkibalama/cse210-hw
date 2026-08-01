using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> _prompts;

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";

        _prompts = new List<string>()
        {
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        };
    }

    /// <summary>
    /// Runs the listing activity, collecting user input for a specified duration.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage();

        // Display random prompt
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];
        Console.WriteLine(prompt);

        // Countdown before starting
        Console.WriteLine();
        Console.Write("You may begin in: ");
        Pause(5); // 5 second countdown

        // Collect items during the session
        List<string> items = new List<string>();
        DateTime startTime = DateTime.Now;

        Console.WriteLine("Start listing items:");
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write("> ");
            string item = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(item))
            {
                items.Add(item);
            }
        }

        Console.WriteLine();
        Console.WriteLine($"You listed {items.Count} items.");

        DisplayEndingMessage();
    }
}
