using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string GetReference()
    {
        return $"{_book} {_chapter}:{_verse}";
    }

    public override string ToString()
    {
        return GetReference();
    }
}