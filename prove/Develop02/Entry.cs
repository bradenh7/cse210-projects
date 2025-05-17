using System;

public class Entry
{
    private string _entry;
    private DateTime _date;

    public Entry(string entry)
    {
        _entry = entry;
        _date = DateTime.Now;
    }

    public string GetEntry()
    {
        return $"{_date.ToShortDateString()}: {_entry}";
    }
}