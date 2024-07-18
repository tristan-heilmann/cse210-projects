using System.Runtime.CompilerServices;

public class ListingActivity : Activity

{
    // variables
    private int _count;
    private List<string> _prompts;
    private List<string> _responses;

    // default variables bc without them the code breaks
    private static string defName = "Listing";
    private static string defDescription = "This activity will help you reflect on the good things in your life " +
    "by having you list as many things as you can in a certain area.";
    private static int defDuration = 0;

    // see?
    public ListingActivity(string name, string description, int duration, int count)
        : base(name, description, duration)

    {
        _count = count;

        InitializeLists();
    }

    // told you
    public ListingActivity(int duration, int count)
        : base(defName, defDescription, defDuration)

    {
        _count = count;

        InitializeLists();
    }

    // oh boy I sure do love listing my thoughts out
    public void RunLA()

    {
        // intro
        Console.Clear();
        Console.WriteLine(defName);
        Console.WriteLine();

        Console.WriteLine(defDescription);
        Console.WriteLine();


        //UPDATE
            // You need to ask for the duration first 
        Console.WriteLine("Please enter a duration (in seconds) for the activity.");
        int dur = int.Parse(Console.ReadLine());
   
            // PROMPT
            var prompt = GetRandomPrompt();
        Console.WriteLine("List as many responses as you can to the following prompt:");
        Console.WriteLine();

        Console.WriteLine($"---{prompt}---");
        Console.WriteLine();

        Console.WriteLine($"You may begin in: ");
        ShowCountdown(5);
   
            // then LOOP HERE for the startTime and futureTime
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(dur);

        _responses = new List<string>();
                
   // this will keep loading everytime you enter, no need for the ReadLine() because is automatic
        do

        {
            Console.Write("> ");
            // user input
            string _userResponse = Console.ReadLine();

            if(!string.IsNullOrEmpty(_userResponse))

            {
                _responses.Add(_userResponse);
            }

            currentTime = DateTime.Now;

        } while (currentTime < futureTime);

        Console.WriteLine($"You listed {_responses.Count()} items!");

        // ending simulation 
        Console.WriteLine();
        Console.WriteLine("Well done. Returning to main menu now...");

        ShowSpinner(5);

        Console.Clear();
    }   

    // third time's the charm! (ok no more gambling jokes)
    public string GetRandomPrompt()

    {
        Random rnd = new Random();

        int index = rnd.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }

    // oh boy another list
    public void InitializeLists()

    {
        _prompts = new List<string>();

        _prompts.Add("Who are the people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }
}