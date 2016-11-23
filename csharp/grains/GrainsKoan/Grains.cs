using System;

namespace GrainsKoan
{
    public class Grains
    {
	    public static ulong Square(int square)
	    {
		    return (ulong) (Math.Pow(2, square - 1));
	    }

	    public static ulong Total()
	    {
		    return Square(65) - 1;
	    }
    }
}
