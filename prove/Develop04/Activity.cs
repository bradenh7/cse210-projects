using System;

public class Activity
{
    private string _activityName;
    private string _activityDescription;
    private int _duration;

    public Activity(string activityName, string activityDescription, int duration)
    {
        _activityName = activityName;
        _activityDescription = activityDescription;
        _duration = duration;
    }

    public void DisplayActivityDetails()
    {
        Console.WriteLine($"Activity: {_activityName}");
        Console.WriteLine($"Description: {_activityDescription}");
        Console.WriteLine($"Duration: {_duration} seconds");
    }

    public static void BufferAnimation()
    {
        Console.Write("Loading");
        while (true)
        {
            "⠁",
            "⠂",
            "⠄",
            "⡀",
            "⢀",
            "⠠",
            "⠐",
            "⠈",
            "⠈⠁",
            "⠈⠂",
            "⠈⠄",
            "⠈⡀",
            "⠈⢀",
            "⠈⠠",
            "⠈⠐",
            "⠈⠈"
            
        }
    }
}