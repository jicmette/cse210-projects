using System;

public class Fraction 
{
    private int _top = 1;
    private int _bottom = 1;

    
    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholesome)
    {
        _top = wholesome;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double DecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

}