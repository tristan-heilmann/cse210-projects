public class ReflectingActivity : Activity

{
    // oh boy more variables
    private List<string> _prompts;
    private List<string> _questions;

    // default variables bc without them the code breaks
    private static string defName = "Reflecting";
    private static string defDescription = "This activity will help you reflect on times in your life when you have shown strength and resilience. " +
        "This will help you recognize the power you have and how you can use it in other aspects of your life.";
    private static int defDuration = 0;

    // remember the two different constructors in Breathing
    public ReflectingActivity(string name, string description, int duration)
        : base(name, description, duration)

    {
        InitializeLists();
    }

    // yeah they're in all three activities
    public ReflectingActivity(int duration)
        : base(defName, defDescription, defDuration)

    {
        InitializeLists();
    }

    // better get thonkin
    public void RunRA()

    {
        // beginning the activity
        Console.Clear();
        Console.WriteLine(defName);
        Console.WriteLine();

        Console.WriteLine(defDescription);
        Console.WriteLine();

        // activity duration
        Console.WriteLine("Please enter a duration (in seconds) for the activity.");
        Console.Write("> ");

        int dur = int.Parse(Console.ReadLine());
        
        DateTime currentTime = DateTime.Now;
        DateTime futureTime = currentTime.AddSeconds(dur);
        
        // beginning simulation
        Console.Clear();

        DisplayPrompt();
        Console.Clear();

        do

        {
        currentTime = DateTime.Now;

        DisplayQuestions();
        Console.WriteLine();

        } while (currentTime <= futureTime);

        // simulation complete
        Console.WriteLine();
        Console.WriteLine("Well done. Returning to main menu now...");

        ShowSpinner(5);

        Console.Clear();
    }

    // let's go gambling! (this is a joke)
    public string GetRandomPrompt()

    {
        Random rnd = new Random();

        int index = rnd.Next(_prompts.Count);

        string prompt = _prompts[index];

        return prompt;
    }

    // let's do it again! (I do not endorse gambling of any kind)
    public string GetRandomQuestion()

    {
        Random rnd = new Random();

        int index = rnd.Next(_questions.Count);

        string question = _questions[index];

        return question;
    }

    // lil pocket dimension to make Run smaller and cleaner
    public void DisplayPrompt()

    {
        var prompt = GetRandomPrompt();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();

        Console. WriteLine($"---{prompt}---");

        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.Write("> ");
        Console.ReadKey();

        Console.WriteLine("Now ponder each of the following questions as they are related to this experience");
        Console.WriteLine($"You may begin in: ");
        
        ShowCountdown(5);
    }

    // another one
    public void DisplayQuestions()

    {
        var question = GetRandomQuestion();

        Console.WriteLine($"> {question}");
        ShowSpinner(5);
    }

    // oh boy I hope you guys like lists
    public void InitializeLists()

    {
        _prompts = new List<string>();

        _prompts.Add("Think of a time when you stood up for someone else.");
        _prompts.Add("Think of a time when you did something really difficult.");
        _prompts.Add("Think of a time when you helped someone in need.");
        _prompts.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();

        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");
    }
}