using System;
using System.Linq;

namespace LargestSeriesKata
{
    public class LargestSeriesProduct
    {
        public static ulong GetLargestProduct(string input, int span)
        {
            if (InvalidSpan(input, span) || InvalidInput(input))
                throw new ArgumentException();
            if (input == "" || span == 0) return 1;
            var digits = input.ToCharArray()
                .Select(x => (int)char.GetNumericValue(x))
                .ToArray();
            ulong maxProduct = 0;
            var maxStart = digits.Length - span + 1;

            for (var i = 0; i < maxStart; i++)
            {
                ulong product = 1;
                for (var j = i; j < i + span; j++)
                {
                    product *= (ulong) digits[j];
                }
                if (product > maxProduct + 1) maxProduct = product;
            }
            return maxProduct;
        }

        private static bool InvalidInput(string input)
        {
            return !input.All(char.IsDigit);
        }

        private static bool InvalidSpan(string input, int span)
        {
            return span > input.Length || span < 0;
        }
    }
}
