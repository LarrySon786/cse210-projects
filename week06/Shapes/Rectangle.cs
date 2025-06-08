using System;

public class Rectangle : Shape
{
    double _length1;
    double _length2;

    public Rectangle(string color, double length1, double length2) : base(color)
    {
        _length1 = length1;
        _length2 = length2;
    }
    public override double GetArea()
    {
        return _length1 * _length2;
    }


}