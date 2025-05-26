using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;

class Scripture
{
    private string _originalText;
    private Reference _reference;
    private List<Word> _text = new List<Word>();
    
    public Scripture()
    {
        _reference = new Reference();

        Console.WriteLine("Please provide the text for the scripture: ");
        string _originalText = Console.ReadLine();
        string toBeSplit = _originalText;
        string[] splitText = toBeSplit.Split(" ");
        foreach (string item in splitText)
        {
            Word eachWord = new Word(item);
            _text.Add(eachWord);
        }
    }

    public void HideRandomWords(int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            Random randomGenerator = new Random();
            int totalIndex = _text.Count();
            int randomIndex = randomGenerator.Next(0, totalIndex);

            // if (_text[randomIndex].IsHidden(_text[randomIndex]) == true)
            // {
            //     numberToHide = numberToHide + 1;
            // }
            // else
            _text[randomIndex].HideWord();
        }
    }

    public void GetDisplayText()
    {

        Console.WriteLine(_reference.GetDisplayReference());
        Console.WriteLine("");
        foreach (Word word in _text)
            if (word.IsHidden(word) == false)
            {
                Console.Write($"{word.GetWord()} ");
            }

            else if (word.IsHidden(word) == true)
            {
                Console.Write($"{word.GetHiddenWord()} ");
            }

            else
            {
                Console.WriteLine("Error");
            }
    }
    public bool CheckHidden()
    {
        foreach (Word item in _text)
        {
            if (item.IsHidden(item) == false)
            {
                return false;
            }
        }
        return true;
    }
    public void GetOriginalText()
    {
        foreach (Word word in _text)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
    public string WriteReference()
    {
        return _reference.GetDisplayReference();
    }
}

    