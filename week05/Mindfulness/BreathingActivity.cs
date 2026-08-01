using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
    }

    /// <summary>
    /// Runs the breathing activity with alternating in/out prompts and countdown pauses.
    /// </summary>
    public void Run()
    {
        DisplayStartingMessage();

        DateTime startTime = DateTime.Now;
        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.WriteLine("Breathe in...");
            Pause(4); // Pause for 4 seconds

            if ((DateTime.Now - startTime).TotalSeconds >= _duration)
                break;

            Console.WriteLine("Breathe out...");
            Pause(4); // Pause for 4 seconds
        }

        DisplayEndingMessage();
    }
}
