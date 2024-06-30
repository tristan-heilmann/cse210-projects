using System;
using System.Runtime.CompilerServices;

class Program

{
    static void Main(string[] args)

    {
        string userInput = "";

        Scripture _isCompletelyHidden = new Scripture();
        Scripture completeScripture = new Scripture();

        Console.WriteLine(completeScripture);
        Console.WriteLine();

        Console.WriteLine("Press enter or type 'Quit' to finish.");
        userInput = Console.ReadLine();

        while (userInput != "Quit")

        {
            Console.Clear();

            Console.WriteLine(completeScripture);
            userInput = Console.ReadLine();
        }

        if (_isCompletelyHidden = true)

        {
            userInput = "Quit";
        }
    }
}