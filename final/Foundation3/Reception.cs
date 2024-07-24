public class Reception : Event

{
    // member variable
    private string _RSVP;

    // constructor
    public Reception(string RSVP, string title, string description, string date, string time, string address, string eventType)
        : base(title, description, date, time, address, eventType)

    {
        _RSVP = RSVP;
    }

    // full details + extra info unique to this event
    public void FullReceptionDetails()

    {
        FullDetails();

        Console.WriteLine($"Registery email: {_RSVP}");
    }
}