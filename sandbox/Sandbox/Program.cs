using System;

class Program
{
    static void Main(string[] args)
    {
    for (int i = 2; i < 20; i =i+2)
        {
            Console.WriteLine($"Hello, World! {i}");
        }
    
    }
    foreach (string color in colors)
    {
        Console.WriteLine(color);

    }
    Random random = new Random();
    int number = random.Next(1, 11);
    Console.WriteLine($"Random number: {number}");
    Random random = new Random();
    int number = random.Next(1, 11);


}