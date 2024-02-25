using System.ComponentModel;

namespace TestTaskMindbox.Figures;

public class Circle : IFigure
{
    private readonly double _radius;

    public Circle(double radius)
    {
        _radius = radius;
    }

    public double GetSquare()
    {
        return Math.PI * _radius * _radius;
    }
}