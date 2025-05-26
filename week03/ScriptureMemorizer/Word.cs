using System;



class Word
{
    private string _word;
    private bool _hidden;

    public Word(string item)
    {
        // letters.count();
        // Hide(letters, hidden)
        _word = item;
        _hidden = false;
    }

    public void HideWord()
    {
        _hidden = true;
    }

    public bool IsHidden(Word item)
    {
        if (item._hidden == false)
            return false;
        else
            return true;
    }

    public string GetWord()
    {
        return _word;
    }


    public string GetHiddenWord()
    {
        string _hiddenWord = "";
        int letters = _word.Count();
        for (int i = 0; i < letters; i++)
        {
            _hiddenWord = _hiddenWord + "_";
        }
        _hiddenWord = _hiddenWord + " ";
        return _hiddenWord;
    }
}