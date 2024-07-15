using Microsoft.VisualBasic;

public class ChecklistGoal : Goal

{
    // member variables
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    // constructor
    public ChecklistGoal(string name, string description, int points)
        : base(name, description, points)

    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    // collecting info
    public void CreateChecklistGoal()
    {
        Console.WriteLine("What is your goal named?");
        Console.Write("> ");
        _shortName = Console.ReadLine();

        Console.WriteLine("What is a short description of it?");
        Console.Write("> ");
        _description = Console.ReadLine();

        Console.WriteLine("How many points would you like to associate with this goal?");
        Console.Write("> ");
        _points = int.Parse(Console.ReadLine());

        Console.WriteLine("How many times does this goal have to be accomplished to get a bonus?");
        Console.Write("> ");
        _target = int.Parse(Console.ReadLine());

        Console.WriteLine("What is the bonus for completing it that many times?");
        Console.Write("> ");
        _bonus = int.Parse(Console.ReadLine());
    }

    public override void RecordEvent()
    {
        throw new NotImplementedException();
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
        return $"Checklist Goal: -{_shortName} -{_description} -{_points} -{_points} -{_bonus} -    {_target} -{_amountCompleted}";
    }
}