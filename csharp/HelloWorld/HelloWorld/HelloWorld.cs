using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace HelloWorld
{
	public static class HelloWorld
	{
		public static string Greeting()
		{
			return "Hello World!";
		}

		public static string Greeting(string name)
		{
			return "Hello " + name + "!";
		}
	}
}
