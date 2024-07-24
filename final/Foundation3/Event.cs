public class Event

{
    // member variables
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected string _address;
    protected string _eventType;

    // constructor
    public Event(string title, string description, string date, string time, string address, string eventType)

    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
        _eventType = eventType;
    }

    // standard event details template
    public void StandardDetails()

    {
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Event description: {_description}");
        Console.WriteLine($"Event date: {_date}");
        Console.WriteLine($"Event time: {_time}");
        Console.WriteLine($"Event address: {_address}");
    }

    // full event details template
    public void FullDetails()

    {
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Event description: {_description}");
        Console.WriteLine($"Event date: {_date}");
        Console.WriteLine($"Event time: {_time}");
        Console.WriteLine($"Event address: {_address}");
    }

    // quick description template
    public void ShortDescription()

    {
        Console.WriteLine($"Event type: {_eventType}");
        Console.WriteLine($"Event title: {_eventTitle}");
        Console.WriteLine($"Event date: {_date}");
    }
}