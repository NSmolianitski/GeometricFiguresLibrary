using GeometricFigures;
using GeometricFigures.Exceptions;
using GeometricFigures.Figures;

namespace GeometricFiguresTests;

public class TriangleTests
{
    [TestCase(1, 2, 3)]
    [TestCase(4, 1, 2)]
    [TestCase(12.5d, 1.27d, 10.3d)]
    [TestCase(2, 3, 55)]
    [TestCase(0, 0, 0)]
    [TestCase(1, 0, 3)]
    [TestCase(1, -1, 3)]
    public void TriangleConstructor_NonValidSides_ThrowsInvalidFigureException(double sideOne, double sideTwo, double sideThree)
    {
        Assert.That(() => new Triangle(sideOne, sideTwo, sideThree), Throws.TypeOf<InvalidFigureException>());
    }
    
    [TestCase(3, 5, 3)]
    [TestCase(4, 5, 2)]
    [TestCase(12.5d, 2.27d, 10.3d)]
    [TestCase(24, 16, 12)]
    [TestCase(5, 5, 5)]
    public void TriangleConstructor_ValidSides_ThrowsNothing(double sideOne, double sideTwo, double sideThree)
    {
        Assert.That(() => new Triangle(sideOne, sideTwo, sideThree), Throws.Nothing);
    }

    [TestCase(13, 5, 12)]
    [TestCase(3, 5, 4)]
    [TestCase(3, 8.54, 8)]
    [TestCase(11.34, 10.94, 3)]
    public void TriangleConstructor_RightTriangleSides_TriangleIsRight(double sideOne, double sideTwo, double sideThree)
    {
        var triangle = new Triangle(sideOne, sideTwo, sideThree);
        
        Assert.That(() => triangle.IsRight, Is.True);
    }
    
    [TestCase(3, 5, 3, 4.146)]
    [TestCase(4, 5, 2, 3.8)]
    [TestCase(12.5, 2.27, 10.3, 3.1726)]
    [TestCase(24, 16, 12, 85.32)]
    [TestCase(5, 5, 5, 10.825)]
    public void GetArea_ValidSides_ReturnsArea(double sideOne, double sideTwo, double sideThree, double area)
    {
        var triangle = new Triangle(sideOne, sideTwo, sideThree);

        var areEqual = CustomMath.AreAlmostEqual(area, triangle.GetArea());
        
        Assert.That(areEqual, Is.True);
    }
}