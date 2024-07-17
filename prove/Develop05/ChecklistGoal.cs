using Microsoft.VisualBasic;

public class ChecklistGoal : Goal

{
    // member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor
    public ChecklistGoal(string name, string description, int points, int target, int bonus)
        : base(name, description, points)

    {
        _amountCompleted = 0;
        _target = target;
        _bonus = bonus;
    }

    public override void RecordEvent()
    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetDetailsString()
    {
        if (IsComplete() == false)

        {
            return $"[ ] {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
        }

        else

        {
            return $"[X] {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        return $"Checklist Goal: {_shortName}-{_description}-{_points}-{_bonus}-{_amountCompleted}-{_target}-{IsComplete()}";
    }
}