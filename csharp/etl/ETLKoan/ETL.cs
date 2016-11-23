using System.Collections.Generic;

namespace ETLKoan
{
	public class ETL
	{
		public static Dictionary<string, int> Transform(Dictionary<int, IList<string>> oldLookup)
		{
			var newLookup = new Dictionary<string, int>();

			foreach (KeyValuePair<int, IList<string>> lookup in oldLookup)
			{
				foreach (string letter in lookup.Value)
				{
					newLookup.Add(letter.ToLower(), lookup.Key);
				}
			}
			return newLookup;
		}
	}
}
