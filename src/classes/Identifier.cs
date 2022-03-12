using System;
using System.Linq;
using System.Text.RegularExpressions;
public static class Identifier
{
    public static string Clean(string identifier)
    {
        char c2;
        int index;
        string identifier2 = identifier;
        char[] chars = { 'β', 'Γ', 'Δ', 'δ', 'ε', 'ζ', 'η', 'Θ', 'θ', 'κ', 'Λ', 'λ', 'μ', 'Ξ', 'ξ', 'Π', 'π', 'Σ', 'ς', 'τ', 'Φ', 'φ', 'χ', 'Ψ', 'ψ', 'Ω', 'ω', 'ι', 'γ' };

        if (identifier2.All(c => !char.IsLetter(c)))
            return string.Empty;

        identifier2 = identifier.Replace(' ', '_');

        // Exluding CTRL characters
        foreach (char c in identifier2)
        {
            if (char.IsControl(c))
                identifier2 = identifier2.Replace(c.ToString(), "CTRL");
        }

        //  Kebab case to pascalCase
        foreach (char c in identifier2)
        {
            if (c == '-')
            {
                index = identifier2.IndexOf(c);
                c2 = identifier2[index + 1];
                identifier2 = identifier2.Replace(c2, char.ToUpper(c2));
            }
        }
        identifier2 = identifier2.Replace("-", "");
        // Omit any greek letter 
        foreach (char c in chars)
        {
            foreach (char item in identifier2)
            {
                if (item == c || char.IsDigit(item))
                    identifier2 = identifier2.Replace(item.ToString(), "");
            }
        }
        identifier2 = Regex.Replace(identifier2, @"\uD83D[\uDC00-\uDFFF]|\uD83C[\uDC00-\uDFFF]|\uFFFD", "");
        return identifier2;
    }
}
