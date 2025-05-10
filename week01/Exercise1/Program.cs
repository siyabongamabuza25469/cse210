using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World1! This is the Exercise 1 Project.");

        Console.Write("What is your first name?");
        string first = Console.ReadLine();

        Console.Write("What is your last name?");
        string last = Console.ReadLine();

        Console.WriteLine($"Your is {last}, {first} {last}.");
    }
}