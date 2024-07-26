using System.Globalization;
using System.Security.Cryptography.X509Certificates;
using Microsoft.Win32.SafeHandles;

public class Running : Activity

{
    // member variables
    private double _distance;

    // constructor
    public Running(double distance, double length)
        : base(length)

    {
        _distance = distance;
    }

    // calculating the distance
    public override double CalculateDistance()

    {
        return Math.Round(_distance);
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
        return $"{GetDate()} Running ({GetLength()} min)- Distance: {CalculateDistance()} miles, Speed: {CalculateSpeed()} mph, Pace: {CalculatePace()} min per mile";
    }
}