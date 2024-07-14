public class ChecklistGoal : Goal

{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points)
        : base(name, description, points)

    {
        _amountCompleted = 0;
        _target = 0;
        _bonus = 0;
    }

    public override void RecordEvent()
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

    public override bool IsComplete()
    {
        throw new NotImplementedException();
    }

    public override string GetDetailsString()
    {
        throw new NotImplementedException();
    }

    public override string GetStringRepresentation()
    {
        return $"[ ] {_shortName} ({_description}) - Currently completed: {_amountCompleted}/{_target}";
    }
}