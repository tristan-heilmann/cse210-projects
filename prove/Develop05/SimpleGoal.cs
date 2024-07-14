public class SimpleGoal : Goal

{
    private bool _isComplete;

    public SimpleGoal(string name, string description, int points)
        : base(name, description, points)

    {
        _isComplete = false;
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
    }

    public override bool IsComplete()

    {
        return _isComplete;
    }

    public override string GetStringRepresentation()

    {
        return $"[ ] {_shortName} ({_description})";
    }
}