using System;
using System.Collections.Generic;

namespace AccumulateKoan
{
    public static class AccumulationExtension 
    {
		public static IEnumerable<TDest> Accumulate<TSrc, TDest>(this IEnumerable<TSrc> source, Func<TSrc, TDest> transform)
		{
			foreach (TSrc elem in source)
			{
				yield return transform(elem);
			}
		}

	}
}
