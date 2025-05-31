using System;

public class Scripture
{
    private List<Word> _words;
    private Reference _reference;

    public Scripture(Reference reference, List<Word> words)
    {
        _reference = reference;
        _words = words;
    }

    public void GetScriptureText()
    {
        Console.WriteLine($"Scripture Reference: {_reference.GetReference()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }
        ;
    }
}