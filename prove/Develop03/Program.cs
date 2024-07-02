using System;
using System.Runtime.CompilerServices;

class Program

{
    static void Main(string[] args)

    {
        string userInput = "";

        Scripture _isCompletelyHidden = new Scripture();
        Scripture displayText = new Scripture();
        displayText.WriteLineSplitter();

        Console.WriteLine(displayText.GetDisplayText());
        Console.WriteLine();

        Console.WriteLine("Press enter or type 'Quit' to finish.");
        userInput = Console.ReadLine();

        while (userInput != "Quit")

        {
            Console.Clear();

            displayText.HideRandomWords(3);

            Console.WriteLine(displayText.GetDisplayText());
            userInput = Console.ReadLine();

            if (displayText.IsCompletelyHidden())

            {
                userInput = "Quit";
            }
        }
    }
}