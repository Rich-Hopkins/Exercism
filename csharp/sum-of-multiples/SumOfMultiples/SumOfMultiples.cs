using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;
using NUnit.Framework.Interfaces;

namespace Sum_Of_Multiples
{
    public static class SumOfMultiples
    {
	    public static int To(int[] multiples, int limit)
	    {
		    int sum = 0;

		    for (int i = 2; i < limit; i++)
		    {
			    foreach (int multiple in multiples)
			    {
				    if (i % multiple == 0)
				    {
					    sum += i;
					    break;
				    }
			    }
		    }
		    return sum;
	    }
    }
}
