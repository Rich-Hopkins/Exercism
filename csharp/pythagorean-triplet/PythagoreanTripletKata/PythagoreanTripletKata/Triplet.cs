using System;
using System.Collections.Generic;
using System.Linq;

namespace PythagoreanTripletKata
{
    public class Triplet
    {
        private int a;
        private int b;
        private int c;

        public Triplet(int a, int b, int c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public int Sum()
        {
            return Sum(a, b, c);
        }

        public int Product()
        {
            return Product(a, b, c);
        }

        private static int Sum(int a, int b, int c)
        {
            return a + b + c;
        }

        private static int Product(int a, int b, int c)
        {
            return a * b * c;
        }

        public bool IsPythagorean()
        {
            var sides = new List<int>();
            sides.Add(a);
            sides.Add(b);
            sides.Add(c);
            sides.Sort();
            return IsPythagorean(sides[0], sides[1], sides[2]);
        }

        private static bool IsPythagorean(int x, int y, int z)
        {
            return x * x + y * y == z * z;
        }

        public static IEnumerable<Triplet> Where(int maxFactor, int? minFactor = null, int? sum = null)
        {
            return Where(maxFactor, minFactor ?? 1, sum);
        }

        private static IEnumerable<Triplet> Where(int maxFactor, int minFactor, int? sum = null)
        {
            return (from a in Enumerable.Range(minFactor, maxFactor - minFactor + 1)
                    from b in Enumerable.Range(a + 1, maxFactor - a)
                    let c = (int)Math.Sqrt(a * a + b * b)
                    where c <= maxFactor
                    where IsPythagorean(a, b, c)
                    where sum == null || Sum(a, b, c) == sum.Value
                    select new Triplet(a, b, c));
        }
    }
}
