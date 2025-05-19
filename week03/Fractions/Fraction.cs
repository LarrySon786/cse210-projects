using System;


class Fraction
{
    private int _numerator;
    private int _denominator;


    public Fraction()
    {
        _numerator = 1;
        _denominator = 1;
    }
    public Fraction(int wholeNumber)
    {
        _numerator = wholeNumber;
        _denominator = 1;
    }
    public Fraction(int numerator, int denominator)
    {
        _numerator = numerator;
        _denominator = denominator;
    }

    public int GetNumerator()
    {
        return _numerator;
    }
    public int GetDenominator()
    {
        return _denominator;
    }
    public string GetFractionString()
    {
        string fractionString = $"{_numerator}/{_denominator}";
        return fractionString;
    }
    public double GetDecimalValue()
    {
        // double points = _numerator / _denominator;
        return (double)_numerator / (double)_denominator;
    }


}


