using System;

class Program
{
    /* CREATIVITY & EXCEEDING REQUIREMENTS:
     * 
     * 1. Improved Animation: The DisplayAnimation method uses a spinner with backspace
     *    characters to create a smooth overwriting effect, making the animation more polished
     *    than simple period display.
     * 
     * 2. Enhanced Breathing Activity: The breathing timing uses 4-second pauses per breath
     *    with countdown display, helping users maintain proper breathing rhythm.
     * 
     * 3. Better UX Flow: The menu is styled with clear sections and prompts, with input
     *    validation to handle invalid menu choices gracefully.
     * 
     * 4. Inheritance Design: Full use of base class for shared starting/ending messages
     *    and animation/pause logic, reducing code duplication across all activity types.
     */

    static void Main()
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            DisplayMenu();
            string choice = Console.ReadLine();

            Activity activity = null;

            switch (choice)
            {
                case "1":
                    activity = new BreathingActivity();
                    break;
                case "2":
                    activity = new ReflectionActivity();
                    break;
                case "3":
                    activity = new ListingActivity();
                    break;
                case "4":
                    continueProgram = false;
                    Console.WriteLine("Thank you for using the Mindfulness Program. Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please select 1, 2, 3, or 4.");
                    continue;
            }

            if (activity != null)
            {
                // Call the appropriate Run method based on activity type
                if (activity is BreathingActivity)
                {
                    ((BreathingActivity)activity).Run();
                }
                else if (activity is ReflectionActivity)
                {
                    ((ReflectionActivity)activity).Run();
                }
                else if (activity is ListingActivity)
                {
                    ((ListingActivity)activity).Run();
                }

                Console.WriteLine();
                Console.Write("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }

    static void DisplayMenu()
    {
        Console.WriteLine();
        Console.WriteLine("╔═══════════════════════════════════════╗");
        Console.WriteLine("║    Welcome to the Mindfulness App     ║");
        Console.WriteLine("╚═══════════════════════════════════════╝");
        Console.WriteLine();
        Console.WriteLine("Select an activity:");
        Console.WriteLine("1. Breathing Activity");
        Console.WriteLine("2. Reflection Activity");
        Console.WriteLine("3. Listing Activity");
        Console.WriteLine("4. Quit");
        Console.WriteLine();
        Console.Write("Enter your choice (1-4): ");
    }
}
