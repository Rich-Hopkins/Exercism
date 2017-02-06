using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace SeriesKata
{
    public class Series
    {
        private List<int> input;

        public Series(string input)
        {
            foreach (var number in input)
            {
                this.input.Add((int)char.GetNumericValue(number));
            }
        }

        public object Slices(int size)
        {
            var slices = new List<int[]>();
            for (int i = 0; i < input.Count - size; i++)
            {
                var slice = new List<int>();
                for (int j = i; j < size; j++)
                {

                }
                slices.Add(slice.ToArray());
            }
            return slices.ToArray();
        }
    }
}
