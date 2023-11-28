using GeometricFigures;
using GeometricFigures.Exceptions;
using GeometricFigures.Figures;

namespace GeometricFiguresTests;

public class CircleTests
{
    [TestCase(0)]
    [TestCase(-1)]
    public void CircleConstructor_InvalidRadius_ThrowsInvalidFigureException(double radius)
    {
        Assert.That(() => new Circle(radius), Throws.TypeOf<InvalidFigureException>());
    }
    
    [TestCase(0.001d)]
    [TestCase(100)]
    public void CircleConstructor_InvalidRadius_ThrowsNothing(double radius)
    {
        Assert.That(() => new Circle(radius), Throws.Nothing);
    }

    [TestCase(5, 78.54)]
    [TestCase(44, 6082.12)]
    [TestCase(21.56, 1460.32)]
    public void GetArea_ValidRadius_ReturnsArea(double radius, double area)
    {
        var circle = new Circle(radius);

        var areEqual = CustomMath.AreAlmostEqual(area, circle.GetArea());
        
        Assert.That(areEqual, Is.True);
    }
}