using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        var letters = input.ToCharArray();
        Array.Reverse(letters);
        return new string(letters);
    }
}