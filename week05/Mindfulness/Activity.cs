using System;

public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration; // in seconds

    /// <summary>
    /// Displays the starting message for any activity with name, description, and prompts for duration.
    /// </summary>
    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name} Activity.");
        Console.WriteLine();
        Console.WriteLine($"Description: {_description}");
        Console.WriteLine();
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare to begin...");
        Pause(3); // Pause for 3 seconds before starting
    }

    /// <summary>
    /// Displays the ending message after activity completion.
    /// </summary>
    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        Pause(2);
        Console.WriteLine($"You have completed another {_duration} second session of the {_name} Activity.");
        Pause(3);
    }

    /// <summary>
    /// Pauses execution and displays a countdown timer or spinner.
    /// </summary>
    /// <param name="seconds">Number of seconds to pause</param>
    public void Pause(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write($"{i} ");
            System.Threading.Thread.Sleep(1000); // 1000ms = 1 second
        }
        Console.WriteLine();
    }

    /// <summary>
    /// Displays an animated spinner while pausing.
    /// </summary>
    /// <param name="seconds">Number of seconds to display spinner</param>
    public void DisplayAnimation(int seconds)
    {
        string[] spinner = { "|", "/", "-", "\\" };
        int spinnerIndex = 0;
        DateTime startTime = DateTime.Now;

        while ((DateTime.Now - startTime).TotalSeconds < seconds)
        {
            Console.Write(spinner[spinnerIndex]);
            System.Threading.Thread.Sleep(250); // 250ms per spinner frame
            Console.Write("\b \b"); // Backspace to overwrite spinner character
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.WriteLine();
    }
}
