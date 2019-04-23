using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        var distance = Math.Sqrt(x * x + y * y);
        return distance > 10 ? 0 : distance > 5 ? 1 : distance > 1 ? 5 : 10;
    }
}
