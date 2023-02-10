using Shapes.Interfaces;
using System;

namespace Shapes;

public class Triangle : IShape, IValidable
{
    /// <summary>
    /// Get area by three sides
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>Area rounded a double-precision floating-point</returns>
    /// <exception cref="ArgumentException"></exception>

    public static double GetArea(params double[] parameters)
    {
        if (parameters.Length != 3) throw new ArgumentException("the method works with three parameters");

        if (!IsValid(parameters[0], parameters[1], parameters[2])) throw new ArgumentException("it is impossible to build a triangle using the passed parameters");

        var semiPerimeter = GetSemiPerimeter(parameters[0], parameters[1], parameters[2]);
        return Math.Round(
            Math.Sqrt(
            semiPerimeter * (semiPerimeter - parameters[0]) * (semiPerimeter - parameters[1]) * (semiPerimeter - parameters[2])), 2);
    }

    /// <summary>
    /// Check is triangle exist
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>true or false</returns>
    public static bool IsValid(params double[] parameters)
    {
        return parameters[0] + parameters[1] > parameters[2]
            && parameters[0] + parameters[2] > parameters[1]
            && parameters[1] + parameters[2] > parameters[0];
    }

    private static double GetSemiPerimeter(double sideA, double sideB, double sideC)
    {
        return (sideA + sideB + sideC)/2;
    }


}