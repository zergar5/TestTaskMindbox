using TestTaskMindbox.Factories;
using TestTaskMindbox.Figures;

namespace UnitTests.FiguresTests;

public class CircleTests
{
    private readonly FigureFactory _figureFactory = new();
    private IFigure _circle;

    [SetUp]
    public void Setup()
    {
        _circle = _figureFactory.CreateFigure(FigureType.Circle, 5d);
    }

    [Test]
    public void CircleSquareTest()
    {
        var expectedSquare = 78.53981633974483096;
        var actualSquare = _circle.GetSquare();

        Assert.That(Math.Abs(expectedSquare - actualSquare), Is.LessThanOrEqualTo(1e-16));
    }
}