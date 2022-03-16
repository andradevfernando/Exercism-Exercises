using System;

public static class ReverseString
{
    public static string Reverse(string input)
    {
        string input2 = "";
        for (int i = input.Length - 1; i >= 0; i--)
        {
            input2 += $"{input[i]}";
        }
        return input2;
    }
}