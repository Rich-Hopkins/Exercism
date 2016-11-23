using System;
using System.Collections.Generic;
using System.Linq;

namespace StrainKoan
{
    public static class Strain
    {
		public static IEnumerable<T> Keep<T>(this IEnumerable<T> inputList, Func<T, bool> predicate)
		{
			return inputList.Where(predicate);
		}

		public static IEnumerable<T> Discard<T>(this IEnumerable<T> inputList, Func<T, bool> predicate)
		{
			var validatedInputList = inputList as IList<T> ?? inputList.ToList();
			return validatedInputList.Except(validatedInputList.Where(predicate));
		}

	}
}
