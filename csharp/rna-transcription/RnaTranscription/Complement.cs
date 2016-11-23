using System.Collections.Generic;

namespace RnaTranscription
{
	public static class Complement
	{
		private static readonly Dictionary<string, string> lookup = new Dictionary<string, string>()
		{
			{"C", "G" },
			{"G", "C" },
			{"T", "A" },
			{"A", "U" }
		};

		public static string OfDna(string s)
		{
			string rv = "";
			foreach (char c in s) rv += lookup[c.ToString()];
			return rv;
			;
		}
	}
}
