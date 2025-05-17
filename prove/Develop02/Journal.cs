using System;

public class Journal
{
    private List<string> entries;

    public Journal()
    {
        entries = new List<string>();
    }

    public void AddEntry(string entry)
    {
        entry += " " + DateTime.Now.ToString("yyyy-MM-dd HH:mm");
        entries.Add(entry);
    }

    public void DisplayEntries()
    {
        foreach (string entry in entries)
        {
            Console.WriteLine(entry);
        }
    }

    public void SaveToFile(string filename)
    {
        System.IO.File.WriteAllLines(filename, entries);
    }

    public void LoadFromFile(string filename)
    {
        if (System.IO.File.Exists(filename))
        {
            entries = new List<string>(System.IO.File.ReadAllLines(filename));
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}