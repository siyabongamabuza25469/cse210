using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello world this is the Exercise2 Project!");

        string userName = PromptUserName();
        int userNumber = PromptUserNumber ();

        int squared = squareNumber(userNumber);

        displayResult(userName, userNumber);
        
    }

    static void displayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int numbers = int.Parse(Console.ReadLine());

        return numbers;
    }

    static int squareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void displayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}