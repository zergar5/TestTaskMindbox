using NuGet.Frameworks;
using TestTaskMindbox.Factories;
using TestTaskMindbox.Figures;

namespace UnitTests.FiguresTests;

public class TriangleTests
{
    private readonly FigureFactory _figureFactory = new();
    private IFigure _triangle;

    [SetUp]
    public void Setup()
    {
        _triangle = _figureFactory.CreateFigure(FigureType.Triangle, 3d, 4d, 5d);
    }

    [Test]
    public void TriangleSquareTest()
    {
        var expectedSquare = 6d;
        var actualSquare = _triangle.GetSquare();

        Assert.That(Math.Abs(expectedSquare - actualSquare), Is.LessThanOrEqualTo(1e-16));
    }

    [Test]
    public void IsRightTriangleTest()
    {
        var expectedIs = true;
        var actualIs = false;

        if (_triangle is Triangle triangle)
        {
            actualIs = triangle.IsRightAngle();
        }

        Assert.That(actualIs, Is.EqualTo(expectedIs));
    }
}