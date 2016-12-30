using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace WordCountKata
{
    public class Phrase
    {
        public static Dictionary<string, int> WordCount(string input)
        {
            var words = new List<string>(input.Split(' ', ',', '.', ':', '!', '&', '@', '$', '%', '^'));
            var counts = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (counts.ContainsKey(word))
                    counts[word]++;
                else
                    counts.Add(word, 1);
            }

            return counts;
        }
    }
}
