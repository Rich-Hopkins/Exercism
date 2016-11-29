using System.Collections.Generic;
using System.Linq;

namespace MatrixKata
{
    public class Matrix
    {
        private List<int>[] grid;

        public Matrix(string input)
        {
            var rows = input.Split('\n');
            var listOfRows = new List<List<int>>();
            foreach (var row in rows)
            {
                var itemsInRow = row.Split(' ');
                var numbers = new List<int>();
                numbers.AddRange(itemsInRow.Select(int.Parse));
                listOfRows.Add(numbers);
            }
            grid = listOfRows.ToArray();
        }
        
        public int Rows => grid.Length;
        public int Cols => grid[0].Count;

        public int[] Row(int i)
        {
            return grid[i].ToArray();
        }

        public int[] Col(int i)
        {
            return grid.Select(list => list[i]).ToArray();
        }
    }
}
