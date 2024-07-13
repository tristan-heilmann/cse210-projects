using System;

// I'm gonna start using comments :D
// to be honest I should've been always doing this
// no idea why I haven't

class Program

{
    static void Main(string[] args)
    
    {
        // setting up the input so that the user can make choices
        string userInput = "";

        // for the intro/outro (for lack of a better term)
        Activity a = new Activity("", "", 0);
        
        // connections to the other files
        BreathingActivity ba = new BreathingActivity(0);
        ReflectingActivity ra = new ReflectingActivity(0);
        ListingActivity la = new ListingActivity(0,0);
        
        // howdy! :D
        a.DisplayStartingMessage();
        Console.WriteLine();

        // input 4 and you explode /j
        while (userInput != "4")

        {
            Console.WriteLine("You have four options:");
            Console.WriteLine();

            // the user's options
            Console.WriteLine("1: Breathing");
            Console.WriteLine("2: Reflecting");
            Console.WriteLine("3: Listing");
            Console.WriteLine("4: Quit");
            Console.WriteLine();

            Console.WriteLine("Which activity would you like to do today?");

            // input time
            Console.Write("> ");
            userInput = Console.ReadLine();

            if (userInput == "1")

            {
                ba.RunBA();
            }

            else if (userInput == "2")

            {
                ra.RunRA();
            }

            else if (userInput == "3")

            {
                la.RunLA();
            }

            else

            {
                // the user has chosen the secret fifth option
                // choosing anything but the given choices and in doing so getting the boot
                Console.Clear();
                a.DisplayEndingMessage();

                Environment.Exit(0);
            }
        }

        // the user has left the building
        Console.Clear();
        a.DisplayEndingMessage();
    }
}