using TestTaskMindbox.Factories;
using TestTaskMindbox.Figures;

namespace UnitTests
{
    public class FigureFactoryTests
    {
        private readonly FigureFactory _figureFactory = new();

        [Test]
        public void CreateCircleTest()
        {
            var circle = _figureFactory.CreateFigure(FigureType.Circle, 5d);

            Assert.That(circle, Is.InstanceOf(typeof(Circle)));
        }

        [Test]
        public void CreateTriangleTest()
        {
            var triangle = _figureFactory.CreateFigure(FigureType.Triangle, 3d, 4d, 5d);

            Assert.That(triangle, Is.InstanceOf(typeof(Triangle)));
        }

        [Test]
        public void CreateRectangleTest()
        {
            var rectangle = _figureFactory.CreateFigure(FigureType.Rectangle, 1d, 2d);

            Assert.That(rectangle, Is.InstanceOf(typeof(Rectangle)));
        }

        [Test]
        public void EmptyParametersTest()
        {
            Assert.Throws<ArgumentException>(() => _figureFactory.CreateFigure(FigureType.Triangle, []));
        }

        [TestCase(new[] { 1d, 2d, 3d })]
        [TestCase(new[] { -1d, 2d, 3d })]
        [TestCase(new[] { 0d, 0d, 0d })]
        [TestCase(new[] { 1d })]
        public void InvalidTriangleParametersTest(double[] parameters)
        {
            Assert.Throws<ArgumentException>(() => _figureFactory.CreateFigure(FigureType.Triangle, parameters));
        }

        [TestCase(new[] { 0d })]
        [TestCase(new[] { -1d })]
        public void InvalidCircleParametersTest(double[] parameters)
        {
            Assert.Throws<ArgumentException>(() => _figureFactory.CreateFigure(FigureType.Circle, parameters));
        }

        [TestCase(new[] { -1d, 2d })]
        [TestCase(new[] { 1d })]
        public void InvalidRectangleParametersTest(double[] parameters)
        {
            Assert.Throws<ArgumentException>(() => _figureFactory.CreateFigure(FigureType.Rectangle, parameters));
        }
    }
}