public abstract class Activity

{
    // member variables
    protected string _date;
    protected double _length; 

    // constructor
    public Activity(double length)

    {
        _length = length;
    }

    // getting the length
    public double GetLength()

    {
        return _length;
    }

    // gettin the date
    public string GetDate()

    {
        DateTime date = DateTime.Now;
        _date = date.ToString("dd/MMM/yyyy");

        return _date;
    }

    // abstractions
    public abstract string GetSummary();
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
}