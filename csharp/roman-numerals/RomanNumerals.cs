using System;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static Dictionary<string, int> romans = new Dictionary<string, int>
    {
        { "M", 1000 },
        {"CM", 900 },
        {"D", 500 },
        {"CD", 400 },
        {"C", 100 },
        {"XC", 90 },
        {"L", 50 },
        {"XL", 40 },
        {"X", 10 },
        {"IX", 9 },
        {"V", 5 },
        {"IV", 4 },
        {"I", 1 }
    };

    public static string ToRoman(this int value)
    {
        var result = "";
        while (value > 0)
        {
            foreach (var roman in romans)
            {

            } 
        }
        return result;
    }

}