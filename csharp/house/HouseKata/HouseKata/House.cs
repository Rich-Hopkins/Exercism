using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Constraints;

namespace HouseKata
{
    public class House
    {
        private string[] nouns =
        {
            "house that Jack built",
            "malt",
            "rat",
            "cat",
            "dog",
            "cow with the crumpled horn",
            "maiden all forlorn",
            "man all tattered and torn",
            "priest all shaven and shorn",
            "rooster that crowed in the morn",
            "farmer sowing his corn",
            "horse and the hound and the horn"
        };

        private string[] verbs =
        {
            "lay in",
            "ate",
            "killed",
            "worried",
            "tossed",
            "milked",
            "kissed",
            "married",
            "woke",
            "kept",
            "belonged to",
            ""
        };

        public static string Rhyme()
        {
            var rhyme = new StringBuilder();


            return rhyme.ToString();
        }
    }
}
