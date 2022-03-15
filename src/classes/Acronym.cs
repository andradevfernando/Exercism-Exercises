using System;
using System.Linq;
using System.Collections;
public static class Acronym
{
    public static string Abbreviate(string phrase)
    {
        var firstChars = phrase.Split(new char[] { ' ', '-', '_' }, StringSplitOptions.RemoveEmptyEntries).Select(s => s.First());
        var firstChars2 = firstChars.Where(s => Char.IsLetter(s));
        string answer = string.Join("", firstChars2).ToUpper();
        Console.WriteLine(answer);
        return answer;
    }
}