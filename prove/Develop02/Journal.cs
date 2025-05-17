using System;

public class Journal
{
    private List<string> _entries;
    public int _saved = 0;

    public Journal()
    {
        _entries = new List<string>();
    }

    public void AddEntry(string entry)
    {
        int lastIndex = PromptGenerator._index;
        entry = PromptGenerator._prompts[lastIndex] + ": " + entry;
        entry += " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        _entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (string entry in _entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        System.IO.File.WriteAllLines(filename, _entries);
        _saved = 1;
    }

    public void LoadFromFile(string filename)
    {
        if (System.IO.File.Exists(filename))
        {
            _entries = new List<string>(System.IO.File.ReadAllLines(filename));
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}