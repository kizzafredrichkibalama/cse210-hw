using System;
using System.Collections.Generic;

public class PromptGenerator
{
    // Member variable - stores a list of prompts
    private List<string> _prompts;
    private Random _random;

    // Constructor - initializes the prompt list with journaling prompts
    public PromptGenerator()
    {
        _prompts = new List<string>();
        _random = new Random();

        // Add at least 5 prompts (can add more!)
        _prompts.Add("Who was the most interesting person I interacted with today?");
        _prompts.Add("What was the best part of my day?");
        _prompts.Add("How did I see the hand of the Lord in my life today?");
        _prompts.Add("What was the strongest emotion I felt today?");
        _prompts.Add("If I had one thing I could do over today, what would it be?");
        
        // Additional creative prompts
        _prompts.Add("What am I grateful for today?");
        _prompts.Add("What challenged me today and how did I respond?");
        _prompts.Add("What made me laugh today?");
        _prompts.Add("What did I learn about myself today?");
        _prompts.Add("What would have made today even better?");
    }

    // GetRandomPrompt - returns a random prompt from the list
    public string GetRandomPrompt()
    {
        int randomIndex = _random.Next(_prompts.Count);
        return _prompts[randomIndex];
    }
}
