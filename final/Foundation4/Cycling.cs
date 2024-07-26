public class Cycling : Activity

{
    // member variables
    private double _speed;

    // constructor
    public Cycling(double speed, double length)
        : base(length)

    {
        _speed = speed;
    }

    // calculating the distance
    public override double CalculateDistance()

    {
        return Math.Round(GetLength() * CalculateSpeed() / 60);
    }

    // calculating the speed
    public override double CalculateSpeed()
    {
        return Math.Round(_speed);
    }

    // calculating the pace
    public override double CalculatePace()
    {
        return Math.Round(60 / CalculateSpeed());
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetLength()} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}