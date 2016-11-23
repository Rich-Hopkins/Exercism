using System;

namespace HammingKoan
{
	public class Hamming
	{
		public static int Compute(string strand1, string strand2)
		{
			if (strand1.Length != strand2.Length)
				throw new ArgumentException("Strands must be equal length.");

			return HammingDifference(strand1, strand2);
		}

		private static int HammingDifference(string strand1, string strand2)
		{
			int difference = 0;
			for (int i = 0; i < strand1.Length; i++)
			{
				if (IsDifferent(strand1, strand2, i))
					difference++;
			}
			return difference;
		}

		private static bool IsDifferent(string strand1, string strand2, int i)
		{
			return strand1.Substring(i, 1) != strand2.Substring(i, 1);
		}
	}
}
