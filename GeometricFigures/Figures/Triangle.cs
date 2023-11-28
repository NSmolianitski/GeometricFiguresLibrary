using GeometricFigures.Exceptions;
using GeometricFigures.Interfaces;

namespace GeometricFigures.Figures;

public class Triangle : IArea
{
    public double SideA { get; }
    public double SideB { get; }
    public double Hypotenuse { get; }

    public bool IsRight { get; }
    
    public Triangle(double sideOne, double sideTwo, double sideThree)
    {
        if (sideOne >= sideTwo + sideThree || sideTwo >= sideOne + sideThree || sideThree >= sideOne + sideTwo)
            throw new InvalidFigureException($"Invalid Triangle: {sideOne} - {sideTwo} - {sideThree}");
        
        var sides = new double[] { sideOne, sideTwo, sideThree };
        Array.Sort(sides);

        if (sides[0] <= 0)
            throw new InvalidFigureException($"Invalid side length: {sides[0]}");
        
        SideA = sides[0];
        SideB = sides[1];
        Hypotenuse = sides[2];

        IsRight = CustomMath.AreAlmostEqual(Hypotenuse * Hypotenuse, SideA * SideA + SideB * SideB);
    }

    public double GetArea()
    {
        // Не совсем понял, для чего нужна проверка на прямоугольный треугольник.
        // Предполагаю, что она нужна для того, чтобы избежать дорогого вычисления корня.
        if (IsRight) 
            return SideA * SideB / 2;
        
        var halfPerimeter = (SideA + SideB + Hypotenuse) / 2;
        return Math.Sqrt(halfPerimeter * 
                         (halfPerimeter - SideA) * 
                         (halfPerimeter - SideB) *
                         (halfPerimeter - Hypotenuse));
    }
}