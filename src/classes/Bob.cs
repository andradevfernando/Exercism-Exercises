using System;
using System.Linq;
public static class Bob
{
    public static string Response(string statement)
    {
        return statement switch
        {
            string n when string.IsNullOrWhiteSpace(statement) => "Fine. Be that way!",
            string n when statement == statement.ToUpper() && statement.EndsWith("?") && statement.Any(c => char.IsLetter(c)) => "Calm down, I know what I'm doing!",
            string n when statement.TrimEnd().EndsWith("?") => "Sure.",
            string n when statement == statement.ToUpper() && statement.Any(c => char.IsLetter(c)) => "Whoa, chill out!",
            _ => "Whatever."
        };
    }
}