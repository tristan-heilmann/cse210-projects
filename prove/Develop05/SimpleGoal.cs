public class SimpleGoal : Goal

{
    // member variables
    private bool _isComplete;

    // constructor
    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)

    {
        _isComplete = false;
    }

    public override void RecordEvent()

    {
        
    }

    public override bool IsComplete()

    {
        return _isComplete;
    }

    public override string GetStringRepresentation()

    {
        return $"Simple Goal:{_shortName}-{_description}-{_points}-{IsComplete()}";
    }
}