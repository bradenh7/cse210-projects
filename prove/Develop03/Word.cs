using System;

public class Word
{
    private string _word;
    private bool _hidden;

    public Word(string word)
    {
        _word = word;
        _hidden = false;
    }

    public string GetWord()
    {
        if (_hidden)
        {
            if (_word.Length < 1.5)
                return _word;
            else 
                return new string('_', _word.Length);
        }
        return _word;
    }
}
