using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace TriangleKata
{
    public static class Triangle
    {
        public static TriangleKind Kind(decimal sideA, decimal sideB, decimal sideC)
        {
            var sides = new decimal[] {sideA, sideB, sideC};
            if (IsInvalid(sides)) throw new TriangleException();
            if (IsEquilateral(sides)) return TriangleKind.Equilateral;
            if (IsIsosceles(sides)) return TriangleKind.Isosceles;
            return TriangleKind.Scalene;
        }

        private static bool IsIsosceles(decimal[] sides)
        {
            return sides[0] == sides[1] 
                || sides[1] == sides[2] 
                || sides[0] == sides[2];
        }

        private static bool IsEquilateral(decimal[] sides)
        {
            return sides[0] == sides[1] 
                && sides[0] == sides[2];
        }

        private static bool IsInvalid(decimal[] sides)
        {
            return sides.Any(side => side < 0)
                || (sides[0] + sides[1] <= sides[2] 
                || sides[1] + sides[2] <= sides[0]
                || sides[0] + sides[2] <= sides[1]);
        }
    }

    public class TriangleException : Exception
    {
    }

    public enum TriangleKind
    {
        Equilateral, Isosceles, Scalene
    }


}
