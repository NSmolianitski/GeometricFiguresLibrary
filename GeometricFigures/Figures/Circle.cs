using GeometricFigures.Exceptions;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Figures;

public class Circle : IArea
{
    public double Radius { get; }

    public Circle(double radius)
    {
        if (radius <= 0)
            throw new InvalidFigureException($"Invalid Circle radius: {radius}");
        
        Radius = radius;
    }

    public double GetArea() => Radius * Radius * Math.PI;
}