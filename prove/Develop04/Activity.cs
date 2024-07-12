public class Activity

{
    // variables
    protected string _name;
    protected string _description;
    protected int _duration;

    // contructor
    public Activity(string name, string description, int duration)

    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    // hello! :D
    public void DisplayStartingMessage()

    {
        Console.WriteLine("Welcome to the R&R program!");
    }
    
    // goodbye! :D
    public void DisplayEndingMessage()

    {
        Console.WriteLine("Buh-bye!");
    }

    // I KNOW HOW YOU WORK NOW
    public void ShowSpinner(int seconds)
 
    {
        for(int i = seconds; i > 0; i--)
        
        {
            Console.Write("+");

            Thread.Sleep(1000);

            Console.Write("\b \b");
            Console.Write("-");
        }
    }

    // YOU TOO
    public void ShowCountdown(int second)

    {
        for(int i = second; i > 0; i--)

        {
            Console.WriteLine(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    // pretty self-explanitory
    public void SetDuration(int duration)

    {
        _duration = duration;
    }
}