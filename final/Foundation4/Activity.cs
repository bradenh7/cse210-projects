public class Activity
{
    private string date;
    private int minutes;

    public Activity(string date, int minutes)
    {
        this.date = date;
        this.minutes = minutes;
    }

    public string GetDate() => date;
    public int GetMinutes() => minutes;

    public virtual double GetDistance() => 0.0;
    public virtual double GetSpeed() => 0.0;
    public virtual double GetPace() => 0.0;

    public virtual string GetSummary()
    {
        return $"{date} {GetType().Name} ({minutes} min): Distance {GetDistance():F2} miles, Speed {GetSpeed():F2} mph, Pace: {GetPace():F2} min per mile";
    }
}