public class EternalGoal : Goal

{
    public EternalGoal(string name, string description, int points)
        : base(name, description, points) {}

    public void CreateEternalGoal()

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

    public override void RecordEvent()

    {
        
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"Eternal Goal:-{_shortName}-{_description}-{_points}-{IsComplete()}";
    }
}