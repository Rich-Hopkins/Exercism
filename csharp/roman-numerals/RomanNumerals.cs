using System;
using System.Collections.Generic;

public static class RomanNumeralExtension
{
    private static readonly Dictionary<int, string> romans = new Dictionary<int, string>
    {
        {1000,"M" },
        {900,"CM" },
        {500, "D"},
        {400, "CD"},
        {100, "C"},
        {90, "XC"},
        {50,"L"},
        {40, "XL"},
        {10, "X"},
        {9, "IX"},
        {5, "V"},
        {4, "IV"},
        {1, "I"}
    };

    public static string ToRoman(this int value) => value < 1 || value > 3499 ? "NOT VALID" : GetRomans(value);

    private static string GetRomans(int value)
    {
        foreach (var roman in romans)
        {
            if (value >= roman.Key)
            {
                return roman.Value + GetRomans(value - roman.Key);
            }
        }
        return "";
    }
}