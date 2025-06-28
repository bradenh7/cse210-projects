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

// SimpleGoal.cs
class SimpleGoal : Goal
{
    private bool _isComplete;

    public override bool IsComplete => _isComplete;

    public SimpleGoal(string name, string description, int points, bool isComplete = false)
        : base(name, description, points)
    {
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        if (!_isComplete)
        {
            _isComplete = true;
            return Points;
        }
        return 0;
    }

    public override string GetStatus() => IsComplete ? "[X]" : "[ ]";

    public override string Serialize() => $"SimpleGoal|{Name}|{Description}|{Points}|{_isComplete}";
}