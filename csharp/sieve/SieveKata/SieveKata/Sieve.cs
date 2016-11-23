using System;
using System.Collections.Generic;

namespace SieveKata
{
    public class Sieve
    {
        public static int[] Primes(int upperLimit)
        {
            var primes = new List<int>();

            for (int i = 2; i <= upperLimit; i++)
            {
                if (IsPrime(i)) primes.Add(i);
            }
            return primes.ToArray();
        }

        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;
            for (var i = 3; i <= Math.Sqrt(number); i += 2)
            {
                if (number % i == 0) return false; ;
            }
            return true;
        }
    }
}
