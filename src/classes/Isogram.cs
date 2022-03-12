using System;
using System.Linq;
using System.Text.RegularExpressions;
public static class Isogram
{
    public static bool IsIsogram(string word)
    {
        foreach (char c in word)
        {
            int count = Regex.Matches(word.ToLower(), c.ToString().ToLower()).Count;
            Console.WriteLine(count);
            if (count > 1 && Char.IsLetter(c))
                return false;
        }
        return true;
    }
}
