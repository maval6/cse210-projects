using System;

public class Word
{
    // Private attributes for the word text and its hidden status.
    private string _text;
    private bool _isHidden;

    // Constructor: Initializes the word with the provided text and sets it as visible.
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hides the word.
    public void Hide()
    {
        _isHidden = true;
    }

    // Shows the word.
    public void Show()
    {
        _isHidden = false;
    }

    // Returns whether the word is hidden.
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns the display text for the word. If the word is hidden, returns underscores matching its length.
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _text.Length);
        }
        else
        {
            return _text;
        }
    }
}

