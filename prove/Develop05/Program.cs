using System;
using Microsoft.VisualBasic;

class Program

{
    static void Main(string[] args)

    {
        // allows accesss to the main menu
        GoalManager menu = new GoalManager();

        // opens the main menu
        menu.Start();
    }
}