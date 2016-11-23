using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace Gigasecond
{
	public static class Gigasecond
	{
		public static DateTime Date(DateTime date)
		{
			return date.AddSeconds(1000000000);
		}
	}
}
