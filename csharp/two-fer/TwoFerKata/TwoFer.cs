namespace TwoFerKata
{
    public static class TwoFer
    {

        public static string Speak(string name = null)
        {
            return string.Format("One for {0}, one for me.", name == null ? "you" : name);
        }
    }
}
