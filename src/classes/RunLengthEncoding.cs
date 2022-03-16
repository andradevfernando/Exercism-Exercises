using System;
using System.Linq;
using System.Collections.Generic;

public static class RunLengthEncoding
{
    public static string Encode(string input)
    {
        if (input == "")
            return input;

        List<string> list = new();
        int index = 0;
        for (int i = 1; i < input.Length; i++)
        {
            if (input[i] != input[i - 1])
            {
                list.Add(input[index..i]);
                index = i;
            }
        }
        list.Add(input[index..input.Length]);

        input = "";
        foreach (var str in list)
        {
            if (str.Length == 1)
                input += $"{str.First()}";
            else
                input += $"{str.Length}{str.First()}";
        }
        return input;
    }

    public static string Decode(string input)
    {
        int index = 0;
        string input2 = "";
        foreach (var c in input)
        {
            if (Char.IsDigit(c) && index == 0)
                index = int.Parse(c.ToString());
            else if (Char.IsDigit(c))
                index = int.Parse($"{index}" + c.ToString());

            if (!Char.IsDigit(c) && index == 0)
                input2 += $"{c}";

            Console.WriteLine(index);
            if (!Char.IsDigit(c) && index != 0)
            {
                for (int i = 0; i < index; i++)
                {
                    input2 += $"{c}";
                }
                index = 0;
            }

            if (!Char.IsDigit(c) && index == 1)
                input2 += $"{c}";
        }
        return input2;
    }
}
