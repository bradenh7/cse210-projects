public class Swimming : Activity
{
    // attribute for Swimming class
    private int laps;

    // constructor for Swimming class
    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        this.laps = laps;
    }

    // override methods for Swimming class
    public override double GetDistance()
    {
        return laps * 50 / 1000.0 * 0.62; // miles
    }

    public override double GetSpeed()
    {
        return (GetDistance() / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}