using System.Linq;
using System.Text;

namespace AcronymKata
{
    public class Acronym
    {
        public static string Abbreviate(string input)
        {
            var words = input.Split(new char[] { ' ', ',', '-' });
            var sb = new StringBuilder();
            foreach (var word in words)
            {
                if (word == string.Empty) continue;
                if (word.Contains(":")) return word.Substring(0, word.Length - 1);
                if (word.Any(c => char.IsUpper(c)))
                {
                    foreach (var letter in word)
                    {
                        if (char.IsUpper(letter)) sb.Append(letter);
                    }
                }
                else sb.Append(word.Substring(0, 1).ToUpper());
            }
            return sb.ToString();
        }
    }
}
