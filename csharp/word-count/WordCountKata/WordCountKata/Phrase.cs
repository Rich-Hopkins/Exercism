using System.Collections.Generic;

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
                var wordLower = word.ToLower().Trim('\'');
                if (counts.ContainsKey(wordLower))
                    counts[wordLower]++;
                else if (wordLower != string.Empty)
                    counts.Add(wordLower, 1);
            }

            return counts;
        }
    }
}
