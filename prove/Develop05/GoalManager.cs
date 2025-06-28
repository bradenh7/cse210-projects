using System;
using System.Collections.Generic;
using System.IO;

class GoalManager
{
    private List<Goal> _goals = new();
    private int _score = 0;

    public void AddGoal(Goal goal) => _goals.Add(goal);

    public void ListGoals()
    {
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetStatus()} {_goals[i].Name} - {_goals[i].Description}");
        }
    }

    public void RecordEvent(int index)
    {
        if (index >= 0 && index < _goals.Count)
        {
            int earned = _goals[index].RecordEvent();
            _score += earned;
            Console.WriteLine($"Points earned: {earned}, Total score: {_score}");
        }
    }

    public void Save(string filename)
    {
        using StreamWriter writer = new(filename);
        writer.WriteLine(_score);
        foreach (var goal in _goals)
        {
            writer.WriteLine(goal.Serialize());
        }
    }

    public void Load(string filename)
    {
        if (!File.Exists(filename)) return;

        string[] lines = File.ReadAllLines(filename);
        _score = int.Parse(lines[0]);
        _goals.Clear();

        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split('|');
            switch (parts[0])
            {
                case "SimpleGoal":
                    _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                    break;
                case "EternalGoal":
                    _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                    break;
                case "ChecklistGoal":
                    _goals.Add(new ChecklistGoal(parts[1], parts[2], int.Parse(parts[3]), int.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6])));
                    break;
            }
        }
    }

    public void DisplayScore() => Console.WriteLine($"Current Score: {_score}");
}