using System.Numerics;

namespace TestTaskMindbox.Figures;

public class Rectangle : IFigure
{
    private readonly double _a;
    private readonly double _b;

    public Rectangle(double a, double b)
    {
        _a = a;
        _b = b;
    }

    public double GetSquare()
    {
        return _a * _b;
    }
}