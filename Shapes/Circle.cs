using Shapes.Interfaces;
using System;

namespace Shapes;

public class Circle : IShape
{
    /// <summary>
    /// Get area by radius
    /// </summary>
    /// <param name="parameters"></param>
    /// <returns>Area rounded a double-precision floating-point</returns>
    /// <exception cref="ArgumentException"></exception>
    public static double GetArea(params double[] parameters)
    {
        if (parameters.Length != 1) throw new ArgumentException("method working with one parameter");

        return Math.Round(Math.PI * Math.Pow(parameters[0], 2), 2);
    }
}
