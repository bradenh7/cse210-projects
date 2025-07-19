public class Cycling : Activity
{
    // attribute for Cycling class
    private double speed;

    // constructor for Cycling class
    public Cycling(string date, int minutes, double speed) : base(date, minutes)
    {
        this.speed = speed;
    }

    // override methods for Cycling class
    public override double GetSpeed() => speed;

    public override double GetDistance() => speed * GetMinutes() / 60;

    public override double GetPace() => 60 / speed;
}