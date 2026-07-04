using System;
using System.Collections.Generic;
using System.Linq;

namespace Exercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> numbers = new List<double>();

            Console.WriteLine("Enter a list of numbers, type 0 when finished.");

            double userNumber = -1; // Initialize to enter the loop

            while (userNumber != 0)
            {
                Console.Write("Enter number: ");
                string input = Console.ReadLine();
                userNumber = double.Parse(input);

                // Add to list only if it's not 0
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }

            if (numbers.Count > 0)
            {
                // Core Requirements
                double sum = numbers.Sum();
                double average = numbers.Average();
                double max = numbers.Max();

                Console.WriteLine($"The sum is: {sum}");
                Console.WriteLine($"The average is: {average}");
                Console.WriteLine($"The largest number is: {max}");

                // Stretch Challenge 1: Smallest positive number
                // Filters for numbers > 0, sorts them, and takes the first
                var positiveNumbers = numbers.Where(n => n > 0).OrderBy(n => n).ToList();
                
                if (positiveNumbers.Count > 0)
                {
                    Console.WriteLine($"The smallest positive number is: {positiveNumbers.First()}");
                }
                else
                {
                    Console.WriteLine("No positive numbers were entered.");
                }

                // Stretch Challenge 2: Sort and display list
                numbers.Sort();
                Console.WriteLine("The sorted list is:");
                foreach (double num in numbers)
                {
                    // Formats the output gracefully matching the assignment style
                    Console.WriteLine(num);
                }
            }
            else
            {
                Console.WriteLine("No numbers were entered.");
            }
        }
    }
}
