namespace exercism.src.classes
{
    public class LogLevels
    {
        public static string Message(string logLine)
        {
            int index = logLine.IndexOf(":") + ":".Length;
            int index2 = logLine.LastIndexOf("");
            string logLine2 = logLine[index..index2].TrimStart().TrimEnd();
            return logLine2;
        }
        public static string LogLevel(string logLine)
        {
            int index = logLine.IndexOf("[") + "[".Length;
            int index2 = logLine.IndexOf("]");
            string logLine2 = logLine[index..index2].TrimStart().ToLower();
            return logLine2;
        }
        public static string Reformat(string logLine)
        {
            int index = logLine.IndexOf("[") + "[".Length;
            int index2 = logLine.IndexOf("]");
            string logLine2 = logLine[index..index2].TrimStart().ToLower();
            index = logLine.IndexOf(":") + ":".Length;
            index2 = logLine.LastIndexOf("");
            string logLine3 = logLine[index..index2].TrimStart().TrimEnd();
            return $"{logLine3} ({logLine2})";
        }
    }
}