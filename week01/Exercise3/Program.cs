using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int quess = -1;

        while (quess != magicNumber)
        {
            Console.Write("What is your quess?");
            quess = int.Parse(Console.ReadLine());

            if (magicNumber > quess)
            {
                Console.WriteLine("Higher");
            }
            else 
            {
                Console.WriteLine("You quessed it!");
            }

        }


    }
}