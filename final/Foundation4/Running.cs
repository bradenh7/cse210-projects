public class Running : Activity
{
    // attribute for Running class
    private double distance;

    // constructor for Running class
    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        this.distance = distance;
    }

    // override methods for Running class
    public override double GetDistance() => distance;

    public override double GetSpeed() => (distance / GetMinutes()) * 60;

    public override double GetPace() => GetMinutes() / distance;
}