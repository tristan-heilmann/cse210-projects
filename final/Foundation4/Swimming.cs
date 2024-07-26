public class Swimming : Activity

{
    // member variables
    private double _laps;

    // constructor
    public Swimming(double laps, double length)
        : base(length)

    {
        _laps = laps;
    }

    // calculating the distance
    public override double CalculateDistance()

    {
        return Math.Round(_laps * 50 / 1000 * 0.62);
    }

    // calculating the speed
    public override double CalculateSpeed()
    {
        return Math.Round(CalculateDistance() / GetLength() * 60);
    }

    // calculating the pace
    public override double CalculatePace()
    {
        return Math.Round(GetLength() / CalculateDistance());
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetLength()} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}