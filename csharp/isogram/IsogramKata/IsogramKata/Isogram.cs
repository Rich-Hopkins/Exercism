using System.Linq;

namespace IsogramKata
{
    public class Isogram
    {
        public static bool IsIsogram(string input)
        {
            var lettersOnly = input.Replace("-", "").Replace(" ", "");
            var chars = lettersOnly.ToLower().ToCharArray();
            var dupilcates = chars
                .GroupBy(c => c)
                .Where(g => g.Count() > 1)
                .Select(g => g.Key);
            return !dupilcates.Any();
        }
    }
}
