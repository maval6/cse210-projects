using System;

public class Reference
{
    // Private attributes for book, chapter, and verse information.
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; // If not provided, _endVerse will equal _verse.

    // Constructor for a single verse (e.g., "John 3:16").
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = verse;
    }

    // Constructor for a range of verses (e.g., "Proverbs 3:5-6").
    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = startVerse;
        _endVerse = endVerse;
    }

    // Returns a display string for the reference.
    public string GetDisplayText()
    {
        if (_verse == _endVerse)
        {
            return $"{_book} {_chapter}:{_verse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
        }
    }
}
