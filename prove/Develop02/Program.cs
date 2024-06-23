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

        if (input == "Write")

        {
            myJournal.AddEntry();
        }

        else if (input == "Display")

        {
            myJournal.DisplayAll();
        }

        else if (input == "Load")

        {
            myJournal.LoadFromFile();
        }

        else if (input == "Save")

        {
            myJournal.SaveToFile();
        }

        else

        {
            Console.WriteLine("Goodbye!");
        }
    }
}