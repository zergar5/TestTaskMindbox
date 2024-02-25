using TestTaskMindbox.Figures;

namespace TestTaskMindbox.Factories;

public class FigureFactory : IFigureFactory
{
    private readonly Dictionary<FigureType, Func<double[], IFigure>> _factoryMethods = [];

    public FigureFactory()
    {
        _factoryMethods.Add(FigureType.Circle, parameters =>
        {
            if (parameters.Length != 1 || parameters[0] <= 0d)
                throw new ArgumentException("Invalid parameters");

            return new Circle(parameters[0]);
        });
        _factoryMethods.Add(FigureType.Triangle, parameters =>
        {
            if (parameters.Length != 3 ||
               parameters[0] + parameters[1] <= parameters[2] ||
               parameters[0] + parameters[2] <= parameters[1] ||
               parameters[1] + parameters[2] <= parameters[0] ||
               parameters[0] <= 0 || parameters[1] <= 0 || parameters[2] <= 0
               )
                throw new ArgumentException("Invalid parameters");

            return new Triangle(parameters[0], parameters[1], parameters[2]);
        });
        _factoryMethods.Add(FigureType.Rectangle, parameters =>
        {
            if (parameters.Length != 2 || parameters[0] <= 0 || parameters[0] <= 0)
                throw new ArgumentException("Invalid parameters");

            return new Rectangle(parameters[0], parameters[1]);
        });
    }

    public IFigure CreateFigure(FigureType figureType, params double[] parameters)
    {
        if (parameters.Length == 0)
            throw new ArgumentException("Invalid parameters");

        try
        {
            var figure = _factoryMethods[figureType](parameters);
            return figure;
        }
        catch (Exception e)
        {
            throw new ArgumentException(e.Message);
        }
    }
}