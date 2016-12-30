using System.Collections.Generic;

namespace AnagramKata
{
    public class Anagram
    {
        private string input;

        public Anagram(string input)
        {
            this.input = input.ToLower();
        }

        public string[] Match(string[] words)
        {
            var matchedWords = new List<string>();


            foreach (var word in words)
            {
                if (word.Length != input.Length) continue;
                if (word.ToLower() == input) continue;

                var lettersToMatch = new List<char>(input);

                foreach (var letter in word.ToLower())
                    lettersToMatch.Remove(letter);
                if (lettersToMatch.Count == 0)
                    matchedWords.Add(word);
            }

            return matchedWords.ToArray();
        }
    }
}
