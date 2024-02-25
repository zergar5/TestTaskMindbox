namespace TestTaskMindbox.Figures;

public class Triangle : IFigure
{
    public double Perimeter => _a + _b + _c;
    public double SemiPerimeter => Perimeter / 2d;

    private readonly double _a;
    private readonly double _b;
    private readonly double _c;

    public Triangle(double a, double b, double c)
    {
        _a = a;
        _b = b;
        _c = c;
    }

    public double GetSquare()
    {
        return Math.Sqrt(SemiPerimeter * (SemiPerimeter - _a) * (SemiPerimeter - _b) * (SemiPerimeter - _c));
    }

    public bool IsRightAngle()
    {
        Span<double> span = [_a, _b, _c];
        span.Sort();

        return Math.Abs(span[0] * span[0] + span[1] * span[1] - span[2] * span[2]) <= 1e-15;
    }
}