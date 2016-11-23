using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RaindropsKoan
{
	public class Raindrops
	{
		public static string Convert(int drops)
		{
			if (Contains357(drops)) return GetSounds(drops);
			return drops.ToString();
		}

		private static bool Contains357(int drops)
		{
			return drops % 3 == 0 || drops % 5 == 0 || drops % 7 == 0;
		}

		private static string GetSounds(int drops)
		{
			string result = "";
			if (drops % 3 == 0) result += "Pling";
			if (drops % 5 == 0) result += "Plang";
			if (drops % 7 == 0) result += "Plong";
			return result;
		}
	}
}
