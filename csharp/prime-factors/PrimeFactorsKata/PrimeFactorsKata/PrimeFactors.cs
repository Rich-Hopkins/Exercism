using System.Collections.Generic;

namespace PrimeFactorsKata
{
  public class PrimeFactors
  {
    public static IEnumerable<int> For(long input)
    {
      if (input < 2) return new int[0];
      List<int> result = new List<int>();
      while (input > 1)
      {
        int factor = GetPrimeFactor(input);
        result.Add(factor);
        input /= factor;
      }
      return result;
    }

    private static int GetPrimeFactor(long number)
    {
      for (int i = 2; i <= number / 2; i++)
      {
        if (number % i == 0) return i;
      }
      return (int)number;
    }
  }
}
