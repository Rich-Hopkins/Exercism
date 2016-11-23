using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace PangramKoan
{
    public class Pangram
    {
	    private static string alphabet = "abcdefghijklmnopqrstuvwxyz";
	    public static bool IsPangram(string input)
	    {
		    return alphabet.All(input.ToLower().Contains);
	    }
    }
}
