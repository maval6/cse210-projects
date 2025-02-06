using System;

public class Fraction
{
    // Private attributes for numerator (top) and denominator (bottom)
    private int _top;
    private int _bottom;

    // Constructor with no parameters; initializes to 1/1
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    // Constructor with one parameter; initializes fraction to wholeNumber/1
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;
    }

    // Constructor with two parameters; initializes fraction to top/bottom
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // Returns the fraction in string form (e.g., "3/4")
    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    // Returns the decimal value of the fraction (e.g., 0.75)
    public double GetDecimalValue()
    {
        // Ensure floating-point division
        return (double)_top / (double)_bottom;
    }
}

