using System;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;

class Program

{
    static void Main(string[] args)
    
    {
        string input = "0";

        Journal myJournal = new Journal();

        do

        {
            Console.WriteLine("Welcome to the Journal Program!");

            Console.WriteLine("Please select one of the following choices:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            Console.Write("Which would you like to do? ");
            input = Console.ReadLine();

            DateTime theCurrentTime = DateTime.Now;

            string file = "";

            if (input == "1")

            {
                string dateText = theCurrentTime.ToShortDateString();

                Entry newEntry = new Entry();
                PromptGenerator prompt = new PromptGenerator();

                newEntry._date = dateText;
                newEntry._promptText = prompt.GetRandomPrompt();

                Console.WriteLine($"Your prompt is {newEntry._promptText}");

                Console.Write("Type in your entry: ");
                newEntry._entryText = Console.ReadLine();

                myJournal.AddEntry(newEntry);
            }

            else if (input == "2")

            {
                myJournal.DisplayAll();
            }

            else if (input == "3")

            {
                Console.Write("What is the file name? ");
                file = Console.ReadLine();

                myJournal.LoadFromFile(file);
            }

            else if (input == "4")

            {
                Console.Write("What is the file name? ");
                file = Console.ReadLine();

                myJournal.SaveToFile(file);
            }

            else

            {
                Environment.Exit(0);
            }

        } while (input != "5");
    }
}