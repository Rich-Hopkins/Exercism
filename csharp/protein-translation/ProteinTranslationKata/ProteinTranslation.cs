using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace ProteinTranslationKata
{
    public static class ProteinTranslation
    {
        private static Dictionary<List<string>, string> codonLookup = new Dictionary<List<string>, string>()
        {
            {new List<string>() {"AUG"}, "Methionine"},
            {new List<string>() {"UUU", "UUC"}, "Phenylalanine"},
            {new List<string>() {"UUA", "UUG"}, "Leucine"},
            {new List<string>() {"UCU", "UCC", "UCA", "UCG"}, "Serine"},
            {new List<string>() {"UAU", "UAC"}, "Tyrosine"},
            {new List<string>() {"UGU", "UGC"}, "Cysteine"},
            {new List<string>() {"UGG"}, "Tryptophan"},
            {new List<string>() {"UAA", "UAG", "UGA"}, "STOP"}
        };
        public static string[] Translate(string codons)
        {
            var codonList = SplitCodons(codons);
            var proteins = new List<string>();
            foreach (var codon in codonList.SelectMany(
                c => codonLookup.Where(
                item => item.Key.Any(
                    key => key == c))))
            {
                if (codon.Value == "STOP")
                {
                    return proteins.ToArray();
                }
                proteins.Add(codon.Value);
            }
            if (CountsNotEqual(codonList, proteins)) throw new Exception();
            return proteins.ToArray();
        }

        private static bool CountsNotEqual(List<string> codonList, List<string> proteins)
        {
            return proteins.Count != codonList.Count;
        }

        private static List<string> SplitCodons(string codons)
        {
            var list = new List<string>();
            var letters = codons.ToCharArray();
            int i = 0;
            do
            {
                var tempCodon =
                    letters[i].ToString() +
                    letters[i + 1].ToString() +
                    letters[i + 2].ToString();
                i += 3;
                list.Add(tempCodon);
            }
            while (i < letters.Length);
            return list;
        }
    }
}

