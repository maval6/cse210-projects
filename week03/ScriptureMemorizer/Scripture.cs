using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    // Private attributes: a Reference object and a list of Word objects.
    private Reference _reference;
    private List<Word> _words;

    // Constructor: Accepts a Reference object and the scripture text.
    // Splits the text into words and creates a Word object for each.
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        string[] wordArray = text.Split(' ');
        _words = new List<Word>();

        foreach (string word in wordArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a specified number of random visible words.
    public void HideRandomWords(int numberToHide)
    {
        // Get a list of indexes for words that are not yet hidden.
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].IsHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        // If there are no visible words, return immediately.
        if (visibleIndexes.Count == 0)
            return;

        Random rand = new Random();
        int count = Math.Min(numberToHide, visibleIndexes.Count);

        // Shuffle the list of visible indexes.
        visibleIndexes = visibleIndexes.OrderBy(x => rand.Next()).ToList();

        // Hide the first 'count' words in the shuffled list.
        for (int i = 0; i < count; i++)
        {
            int index = visibleIndexes[i];
            _words[index].Hide();
        }
    }

    // Returns the display text, including the reference and the scripture text.
    public string GetDisplayText()
    {
        string displayText = _reference.GetDisplayText() + "\n";
        foreach (Word word in _words)
        {
            displayText += word.GetDisplayText() + " ";
        }
        return displayText.Trim();
    }

    // Checks if every word in the scripture is hidden.
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}

