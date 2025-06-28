using System;

abstract class Goal
{
    public string Name { get; protected set; }
    public string Description { get; protected set; }
    public int Points { get; protected set; }
    public abstract bool IsComplete { get; }

    public Goal(string name, string description, int points)
    {
        Name = name;
        Description = description;
        Points = points;
    }

    public abstract int RecordEvent();
    public abstract string GetStatus();
    public abstract string Serialize();
}

