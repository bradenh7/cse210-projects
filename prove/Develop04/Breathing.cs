using System;

public class Breathing : Activity
{
    public Breathing(int duration)
        : base("Breathing", "Focus on your breathing to relax and center yourself.", duration)
    {
    }

    public void StartBreathingExercise()
    {
        Console.WriteLine("Starting Breathing Exercise...");
        DisplayActivityDetails();
        Console.WriteLine("Breathe in deeply through your nose...");
        System.Threading.Thread.Sleep(2000); // Simulate breathing in
        Console.WriteLine("Hold your breath for a moment...");
        System.Threading.Thread.Sleep(2000); // Simulate holding breath
        Console.WriteLine("Now breathe out slowly through your mouth...");
        System.Threading.Thread.Sleep(2000); // Simulate breathing out
        Console.WriteLine("Breathing exercise completed.");
    }
    
    
}