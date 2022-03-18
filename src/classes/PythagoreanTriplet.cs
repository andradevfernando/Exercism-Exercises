using System;
using System.Collections.Generic;

public static class PythagoreanTriplet
{
    public static IEnumerable<(int a, int b, int c)> TripletsWithSum(int sum)
    {
        int a, b, c;
        double check;
        List<(int a, int b, int c)> triplets = new();
        for (int i = 0; i < sum / 3; i++)
        {
            a = i;
            for (int j = a; j < sum / 2; j++)
            {
                b = j;
                check = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));

                if (check % 1 == 0)
                {
                    c = (int)check;
                    if (a + b + c == sum && Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && b > a)
                        triplets.Add((a, b, c));
                }
            }
        }
        foreach (var item in triplets)
        {
            Console.WriteLine(item);
        }
        return triplets;
    }
}