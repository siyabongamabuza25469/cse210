using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        
        // For Part 1 and 2, the user characterized the number
        Console.Write("What is the magic number?");
        int magicNumber = int.Parse(Console.ReadLine());

        // For Part 3, a random number is used
        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);

        int quess = -1;

        //Used of a do-while loop
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