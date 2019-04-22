using System;

public static class ArmstrongNumbers
{
    public static bool IsArmstrongNumber(int number)
    {
        var numArray = number.ToString().ToCharArray();
        double newNumber = 0;
        foreach (var n in numArray)
        {
            newNumber += Math.Pow(char.GetNumericValue(n), numArray.Length);
        }
        return number == newNumber;
    }
}