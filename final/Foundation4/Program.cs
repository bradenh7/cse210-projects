using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Create some Address objects
        List<Activity> activities = new List<Activity>
        {
            new Running("03 Nov 2022", 30, 3.0),
            new Cycling("03 Nov 2022", 45, 15.0),
            new Swimming("03 Nov 2022", 30, 40)
        };

        // Display summaries of activities
        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }
    }
}