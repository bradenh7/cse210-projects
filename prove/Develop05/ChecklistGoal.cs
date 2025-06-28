class ChecklistGoal : Goal
{
    private int _targetCount;
    private int _currentCount;
    private int _bonusPoints;

    public override bool IsComplete => _currentCount >= _targetCount;

    public ChecklistGoal(string name, string description, int points, int targetCount, int bonusPoints, int currentCount = 0)
        : base(name, description, points)
    {
        _targetCount = targetCount;
        _bonusPoints = bonusPoints;
        _currentCount = currentCount;
    }

    public override int RecordEvent()
    {
        if (!IsComplete)
        {
            _currentCount++;
            return Points + (IsComplete ? _bonusPoints : 0);
        }
        return 0;
    }

    public override string GetStatus() => IsComplete ? "[X]" : $"[{_currentCount}/{_targetCount}]";

    public override string Serialize() => $"ChecklistGoal|{Name}|{Description}|{Points}|{_targetCount}|{_bonusPoints}|{_currentCount}";
}
