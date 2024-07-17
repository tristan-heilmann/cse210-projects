using System;
using Microsoft.VisualBasic;

class Program

{
    static void Main(string[] args)

    {
        // allows accesss to the main menu
        GoalManager menu = new GoalManager();

        var input = 0;

        do

        {

        // opens the main menu
        menu.Start();

        } while (input == 6);
    }
}