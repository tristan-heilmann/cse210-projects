public class EternalGoal : Goal

{
    // constructor
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public override void RecordEvent()

    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal: {_shortName}-{_description}-{_points}-{IsComplete()}";
    }
}