public class BreathingActivity : Activity

{
    // default variables bc without them the code breaks
    private static string defName = "Breathing";
    private static string defDescription = "This activity will help you relax by walking you through your breathing in and out steadily. " + 
        "Clear your mind and focus on your beathing.";
    private static int defDuration = 0;

    // constructors
    public BreathingActivity(string name, string description, int duration)
        : base(name, description, duration) {}

    // why are there two of them? Idk :D
    // jokes aside this one's for the default values
    public BreathingActivity(int duration)
        : base(defName, defDescription, defDuration) {}

    // oh boy time to breathe
    public void RunBA()

    {
        // intro to the activity
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

        Console.WriteLine("Beginning activity...");

        ShowSpinner(5);

        do
 
        {
            // you are now breathing manually
            Console.WriteLine();
            Console.WriteLine($"Breath in...");

            ShowCountdown(2);

            Console.WriteLine();
            Console.WriteLine($"Breath out...");

            ShowCountdown(3);
        } while (currentTime <= futureTime);

        // you are still breathing manually but at least you're not being told to do so
        Console.WriteLine();
        Console.WriteLine("Well done. Returning to main menu now...");

        ShowSpinner(5);
        
        Console.Clear();
    }
}