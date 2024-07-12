public abstract class Goal

{
    protected string _shortName;
    protected string _description;
    protected string _points;

    public Goal(string name, string description, string points)

    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public abstract void RecordEvent();

    public abstract bool IsComplete();
    public abstract string GetDetailsString();

    public abstract string GetStringRepresentation();
}