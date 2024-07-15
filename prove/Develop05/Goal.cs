using System.Reflection.Metadata.Ecma335;

public abstract class Goal

{
    // member variables
    protected string _shortName;
    protected string _description;
    protected int _points;

    // constructor
    public Goal(string name, string description, int points)

    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    // abstracts to be overridden in the three goal types
    public abstract void RecordEvent();
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    // this one's a bit different than it's peers
    // it's a default for two of the classes and only needs overriding by one
    public virtual string GetDetailsString()

    {
        if (IsComplete() == false)

        {
            return $"[ ] {_shortName} ({_description})";
        }

        else

        {
            return $"[X] {_shortName} ({_description})";
        }
    }
}