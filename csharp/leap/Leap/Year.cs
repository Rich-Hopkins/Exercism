using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Leap
{
	public static class Year
	{
		public static bool IsLeap(int year)
		{
			if (IsLeapYear(year)) return true;
			return false;
		}

		private static bool IsLeapYear(int year)
		{
			return (year % 100 != 0 || year % 400 == 0) && year % 4 == 0;
		}
	}
}
