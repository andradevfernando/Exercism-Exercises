using System;
using System.Linq;
using System.Collections.Generic;
public class Anagram
{
    private string baseWord { get; set; }
    public Anagram(string baseWord)
    {
        this.baseWord = baseWord;
    }

    public string[] FindAnagrams(string[] potentialMatches)
    {
        int count = 0;
        List<string> candidates2 = new();
        char[] sortBaseWord = baseWord.ToLower().ToCharArray();
        List<string> candidates3 = new();
        var potentialMatches2 = potentialMatches.Where(x => x.Length == baseWord.Length);

        foreach (var candidate in potentialMatches2)
        {
            count = 0;
            char[] candidateArray = candidate.ToLower().ToCharArray();
            for (int i = 0; i < candidateArray.Length; i++)
            {
                if (sortBaseWord[i] == candidateArray[i])
                    count++;
            }
            if (count != baseWord.Length)
            {
                candidates3.Add(candidate);
            }
        }

        string[] candidates = candidates3.ToArray();

        foreach (var candidate in candidates)
        {
            char[] candidateArray = candidate.ToLower().ToCharArray();
            Array.Sort(candidateArray);
            Array.Sort(sortBaseWord);
            count = 0;
            for (int i = 0; i < candidateArray.Length; i++)
            {

                if (sortBaseWord[i] == candidateArray[i])
                    count++;
            }
            Console.WriteLine(count);

            if (count == baseWord.Length)
            {
                candidates2.Add(candidate);
            }
        }

        return candidates2.ToArray();
    }
}