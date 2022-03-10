namespace exercism.src.classes;


public static class LogAnalysis
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int index = str.IndexOf(delimiter) + delimiter.Length;
        return str[index..str.Length];
    }

    public static string SubstringBetween(this string str, string delimiter, string delimiter2)
    {
        int index = str.IndexOf(delimiter) + delimiter.Length;
        int index2 = str.LastIndexOf(delimiter2);
        return str[index..index2];
    }

    public static string Message(this string str)
    {
        int index = str.IndexOf(":") + ":".Length;
        int index2 = str.LastIndexOf("");
        string logLine2 = str[index..index2].TrimStart().TrimEnd();
        return logLine2;
    }

    public static string LogLevel(this string str)
    {
        int index = str.IndexOf("[") + "[".Length;
        int index2 = str.IndexOf("]");
        string logLine2 = str[index..index2].TrimStart();
        return logLine2;
    }
}
