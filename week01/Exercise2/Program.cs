using System;

class Program
{
    static void Main()
    {
        // 1. Core Requirements & Exceptions
        Console.Write("Enter your grade percentage: ");
        string input = Console.ReadLine();
        int grade = int.Parse(input);

        string letter = "";
        
        // Determine base letter grade
        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        // 2. Stretch Challenge: Determine sign (+ or -)
        int lastDigit = grade % 10;
        string sign = "";

        // Detect if sign modifier is applicable
        if (letter != "A" && letter != "F")
        {
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        // Handle maximum grade exceptions for "A"
        else if (letter == "A" && grade < 93) 
        {
            sign = "-";
        }
        
        // 3. Print the final grade and passing status
        Console.WriteLine("Your letter grade is: " + letter + sign);

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course.");
        }
        else
        {
            Console.WriteLine("Don't give up! You can do it next time.");
        }
    }
}
