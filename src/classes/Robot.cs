using System;
using System.Linq;
using System.Collections.Generic;
public class Robot
{
    public static List<string> id = new();
    public static string letters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static Random random = new();
    public char letra = letters.ElementAt(random.Next(letters.Length));
    public char letra2 = letters.ElementAt(random.Next(letters.Length));

    public int inteiro = random.Next(100, 999);
    public string Name
    {
        get
        {
            return $"{letra}{letra2}{inteiro}";
        }

    }
    public Robot()
    {
        GetName();
    }

    public void Reset()
    {
        letra = letters.ElementAt(random.Next(letters.Length));
        letra2 = letters.ElementAt(random.Next(letters.Length));
        inteiro = random.Next(100, 999);
    }
    public int IntName()
    {
        int count = 0;
        foreach (var i in id)
        {
            if (i == $"{letra}{letra2}{inteiro}")
                count++;
        }
        return count;
    }
    public void GetName()
    {
        while (IntName() != 0)
        {
            Reset();
        }
        if (IntName() == 0)
            id.Add($"{letra}{letra2}{inteiro}");


    }
}