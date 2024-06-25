using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program

{
    static void Main(string[] args)

    {
        Console.WriteLine("Welcome to the Journal Program!");

        Console.WriteLine("Please select one of the following choices:");

        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");

        Console.Write("Which would you like to do? ");
        string input = Console.ReadLine();

        Journal myJournal = new Journal();

        if (input == "1")

        {
            myJournal.AddEntry();
        }

        else if (input == "2")

        {
            myJournal.DisplayAll();
        }

        else if (input == "3")

        {
            myJournal.LoadFromFile();
        }

        else if (input == "4")

        {
            myJournal.SaveToFile();
        }

        else

        {
            Console.WriteLine("Goodbye!");
        }
    }
}