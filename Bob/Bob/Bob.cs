using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Bob
{
	public class Bob
	{
		public static string Hey(string sentence)
		{
			if (IsCaps(sentence) && !IsLower(sentence)) return "Whoa, chill out!";
			if (IsQuestion(sentence)) return "Sure.";
			if (IsSilence(sentence)) return "Fine. Be that way!";
			return "Whatever.";
		}

		private static bool IsSilence(string sentence)
		{
			return sentence.Trim() == "";
		}

		private static bool IsQuestion(string sentence)
		{
			return sentence.Trim().EndsWith("?");
		}

		private static bool IsCaps(string sentence)
		{
			return sentence == sentence.ToUpper();
		}

		private static bool IsLower(string sentence)
		{
			return sentence == sentence.ToLower();
		}
	}
}
