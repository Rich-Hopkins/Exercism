using System;
using System.Collections.Generic;

namespace SeriesKata
{
  public class Series
  {
    private List<int> _input = new List<int>();

    public Series(string input)
    {
      foreach (var number in input)
      {
        this._input.Add((int)char.GetNumericValue(number));
      }
    }

    public object Slices(int size)
    {
      if (size > _input.Count) throw new ArgumentException();
      var slices = new List<int[]>();
      for (int i = 0; i < _input.Count - size + 1; i++)
      {
        var slice = new List<int>();
        for (int j = i; j < size + i; j++)
        {
          slice.Add(_input[j]);
        }
        slices.Add(slice.ToArray());
      }
      return slices.ToArray();
    }
  }
}
