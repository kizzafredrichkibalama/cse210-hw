using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your FirstName? ");
        string firstName = Console.ReadLine();
        Console.Write("What is your LastName? ");
        string lastName = Console.ReadLine();
        Console.WriteLine($"You name is, {firstName} {lastName}!");

    }
}