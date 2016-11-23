using System.Text;

namespace BeerSongKata
{
    public class Beer
    {
        private static int nextVerse;
        public static string Verse(int verseNumber)
        {
            nextVerse = verseNumber - 1;
            string bottle = BottlePlurality(verseNumber);
            string takeDown = TakeDown(verseNumber);
            string nextRound = LastLine(nextVerse);

            return string.Format("{0} of beer on the wall, {1} of beer." +
                "\n{2}, {3} of beer on the wall.\n"
                , bottle, bottle.ToLower(), takeDown, nextRound);
        }

        public static string Sing(int start, int stop)
        {
            StringBuilder song = new StringBuilder();

            for (int i = start; i >= stop; i--)
            {
                song.Append(Verse(i));
                song.Append("\n");
            }
            return song.ToString();
        }

        private static string LastLine(int count)
        {
            if (count == 0) return "no more bottles";
            return count > 1 ? count + " bottles" : count + " bottle";
        }

        private static string TakeDown(int count)
        {
            if (count == 0)
            {
                nextVerse = 99;
                return "Go to the store and buy some more";
            }
            string endOfLine = " down and pass it around";
            return count > 1 ? "Take one" + endOfLine : "Take it" + endOfLine;
        }

        private static string BottlePlurality(int count)
        {
            if (count == 0) return "No more bottles";
            return count > 1 || count < 1 ? count + " bottles" : count + " bottle";
        }
    }
}
