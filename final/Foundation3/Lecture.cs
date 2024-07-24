public class Lecture : Event

{
    // member variables
    private string _speaker;
    private string _capacity;

    // constructor
    public Lecture(string title, string description, string date, string time, string address, string eventType, string speaker, string capacity)
        : base(title, description, date, time, address, eventType)

    {
        _speaker = speaker;
        _capacity = capacity;
    }
    
    // full details + extra info unique to this event
    public void FullLectureDetails()

    {
        FullDetails();

        Console.WriteLine($"Speaker: {_speaker}");
        Console.WriteLine($"Lecture capacity: {_capacity}");
    }
}