using System;
using System.Linq;
public static class Pangram
{
    public static bool IsPangram(string input)
    {
        int j = 0;
        char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        foreach (char c2 in alphabet)
        {
            if (input.ToLower().Contains(c2))
                j++;
        };
        return j switch
        {
            26 => true,
            _ => false
        };
    }
}

