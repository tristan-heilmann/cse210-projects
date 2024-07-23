public class Event

{
    protected string _eventTitle;
    protected string _description;
    protected int _date;
    protected int _time;
    protected Address _address;

    public Event(string title, string description, int date, int time, Address address)

    {
        _eventTitle = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    
}