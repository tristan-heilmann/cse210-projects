public class OutdoorGathering : Event

{
    // member variable
    private string _weather;

    // constructor
    public OutdoorGathering(string weather, string title, string description, string date, string time, string address, string eventType)
        : base(title, description, date, time, address, eventType)

    {
        _weather = weather;
    }

    // full details + extra info unique to this event
    public void FullOutdoorGatheringDetails()

    {
        FullDetails();

        Console.WriteLine($"Weather forcast: {_weather}");
    }
}