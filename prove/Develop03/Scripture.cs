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
        Console.Clear();
        Console.WriteLine($"Scripture Reference: {_reference.GetReference()}");
        foreach (Word word in _words)
        {
            Console.Write($"{word.GetWord()} ");
        }

    }

    public void HideWords()
    {
        Random random = new Random();

       
        var available = _words
            .Where(w => !w.IsHidden() && w.GetWord() != "." && w.GetWord() != ",")
            .ToList();

        if (available.Count == 0)
        {
            Console.WriteLine("\nAll words are hidden!");
            return;
        }

        int toHide = Math.Min(3, available.Count); 
        for (int i = 0; i < toHide; i++)
        {
            int index = random.Next(available.Count);
            available[index].Hide();
            available.RemoveAt(index); 
        }
    }


    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden() || w.GetWord() == "." || w.GetWord() == ",");
    }



}