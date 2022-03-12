using System;
using System.Globalization;
public static class RotationalCipher
{
    public static string Rotate(string text, int shiftKey)
    {
        int index;
        char[] alphabet = new[] { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
        char[] upperAlphabet = new[] { 'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z' };
        char[] chars = text.ToCharArray();

        for (int i = 0; i < chars.Length; i++)
        {
            if (Char.IsUpper(chars[i]))
            {
                index = new string(upperAlphabet).IndexOf(chars[i]);

                if (index + shiftKey > 25 && Char.IsLetter(chars[i]))
                    chars[i] = upperAlphabet[index + shiftKey - 26];
                else if (Char.IsLetter(chars[i]))
                    chars[i] = upperAlphabet[index + shiftKey];
            }
            else
            {
                index = new string(alphabet).IndexOf(chars[i]);

                if (index + shiftKey > 25 && Char.IsLetter(chars[i]))
                    chars[i] = alphabet[index + shiftKey - 26];
                else if (Char.IsLetter(chars[i]))
                    chars[i] = alphabet[index + shiftKey];
            }
        }
        return new string(chars);
    }
}