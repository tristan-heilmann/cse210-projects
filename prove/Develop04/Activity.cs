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

    // *repeatedly poking this function*
    // how do you work?
    public void ShowSpinner(int seconds)
 
    {
        Console.Write(seconds);

        for(int i = 0; i < seconds.ToString().Length; i++)
        
        {
            Console.Write("\b \b");
            Console.Write("-");
        }
    }

    // yeah idk how this one works either
    public void ShowCountdown(int second)

    {

    }

    // pretty self-explanitory
    public void SetDuration(int duration)

    {
        _duration = duration;
    }
}