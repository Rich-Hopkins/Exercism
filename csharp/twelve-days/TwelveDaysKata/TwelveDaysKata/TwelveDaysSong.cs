using System.Text;

namespace TwelveDaysKata
{
    public class TwelveDaysSong
    {
        private readonly string[] days =
        {
            "first", "second", "third", "fourth", "fifth", "sixth",
            "seventh", "eighth", "ninth", "tenth", "eleventh", "twelfth"
        };
        private readonly string[] gifts =
        {
            "a Partridge in a Pear Tree.", "two Turtle Doves", "three French Hens",
            "four Calling Birds", "five Gold Rings", "six Geese-a-Laying",
            "seven Swans-a-Swimming", "eight Maids-a-Milking", "nine Ladies Dancing",
            "ten Lords-a-Leaping", "eleven Pipers Piping", "twelve Drummers Drumming"
        };

        public string Verse(int verseNumber)
        {
            var verse = new StringBuilder();
            verse.Append("On the " + days[verseNumber - 1]
                + " day of Christmas my true love gave to me, ");

            for (var i = verseNumber; i > 1; i--)
            {
                verse.Append(gifts[i - 1]);
                verse.Append(", ");
            }
            if (verseNumber > 1) verse.Append("and ");
            verse.Append(gifts[0] + "\n");

            return verse.ToString();
        }

        public string Verses(int startVerse, int endVerse)
        {
            var verses = new StringBuilder();
            for (var i = startVerse; i <= endVerse; i++)
            {
                verses.Append(Verse(i) + "\n");
            }

            return verses.ToString();
        }

        public string Sing()
        {
            return Verses(1, 12);
        }
    }
}
