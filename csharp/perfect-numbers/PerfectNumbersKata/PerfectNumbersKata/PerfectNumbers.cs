using System.Collections.Generic;
using System.Linq;

namespace PerfectNumbersKata
{
    public enum NumberType
    {
        Abundant, Perfect, Deficient
    }
    public class PerfectNumbers
    {
        public static NumberType Classify(int number)
        {
            var difference = Factors(number).Sum() - number;

            if(difference == 0) return NumberType.Perfect;

            return difference > 0 ? NumberType.Abundant : NumberType.Deficient;
        }

        private static List<int> Factors(int number)
        {
            var factors = new List<int>();
            for (var i = 1; i <= number/2; i++)
            {
                if (number%i == 0)
                {
                    factors.Add(i);
                }
            }

            return factors;
        }
    }

}
