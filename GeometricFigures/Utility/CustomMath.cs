namespace GeometricFigures;

public static class CustomMath
{
    public const double Epsilon = 0.1d;
    
    public static bool AreAlmostEqual(double numberOne, double numberTwo, double epsilon = Epsilon)
    {
        return Math.Abs(numberOne - numberTwo) < epsilon;
    }
}