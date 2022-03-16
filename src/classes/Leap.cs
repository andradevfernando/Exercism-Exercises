using System;

public static class Darts
{
    public static int Score(double x, double y)
    {
        double position;
        if (x == 0)
            position = Math.Abs(y);
        else if (y == 0)
            position = Math.Abs(x);
        else
            position = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));


        if (position >= 0 && position <= 1)
            return 10;

        if (position > 1 && position <= 5)
            return 5;

        if (position > 5 && position <= 10)
            return 1;
        else
            return 0;
    }
}
