using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction number = new Fraction();
        Fraction number1 = new Fraction(4);
        Fraction number2 = new Fraction(2, 3);
        Console.WriteLine(number1.GetDenominator());
        Console.WriteLine(number1.GetNumerator());
        Console.WriteLine(number2.GetFractionString());
        Console.WriteLine(number2.GetDecimalValue());
    }
}