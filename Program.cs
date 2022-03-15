using System;
using System.Linq;
using exercism.src.classes;
public class Program
{
    public static void Main()
    {
        var candidates = new[] { "dog", "goody" };
        var sut = new Anagram("good");
        sut.FindAnagrams(candidates);
    }
}