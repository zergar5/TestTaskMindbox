using TestTaskMindbox.Figures;

namespace TestTaskMindbox.Factories;

public interface IFigureFactory
{
    public IFigure CreateFigure(FigureType figureType, params double[] parameters);
}

public enum FigureType
{
    Circle,
    Triangle,
    Rectangle
}