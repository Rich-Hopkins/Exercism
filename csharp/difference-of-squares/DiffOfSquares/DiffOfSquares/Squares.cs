using System;

namespace DiffOfSquares
{
	public class Squares
	{
		private int squares;

		public Squares(int i)
		{
			if (i < 0) throw new ArgumentException();
			squares = i;
		}

		public int SquareOfSums()
		{
			int sum = 0;
			for (int i = 0; i <= squares; i++)
			{
				sum += i;
			}
			return (int) Math.Pow(sum, 2);
		}

		public int SumOfSquares()
		{
			int sum = 0;
			for (int i = 0; i <= squares; i++)
			{
				sum += (int) Math.Pow(i, 2);
			}
			return sum;
		}

		public int DifferenceOfSquares()
		{
			return SquareOfSums() - SumOfSquares();
		}
	}
}
