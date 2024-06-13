using System;
using System.Reflection.Metadata;

class Program
{

    static void Main(string[] args)

    {
        Random random_generator = new Random();
        int magic_number = random_generator.Next(1, 101);

        int guess = -1;

        while (guess != magic_number)

        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess > magic_number)

            {
                Console.WriteLine("Lower");
            }

            else if (guess < magic_number)

            {
                Console.WriteLine("Higher");
            }

            else

            {
                Console.WriteLine("You got it!");
            }
        }
    }
}