using System;
using System.Globalization;
public static class HighSchoolSweethearts
{
    public static string DisplaySingleLine(string studentA, string studentB)
    {
        return string.Format("{0,29} ♡ {1,-29}", studentA, studentB);
    }

    public static string DisplayBanner(string studentA, string studentB)
    {
        return @$" ******       ******
   **      **   **      **
 **         ** **         **
**            *            **
**                         **
**     {studentA} +  {studentB}    **
 **                       **
   **                   **
     **               **
       **           **
         **       **
           **   **
             ***
              *";
    }

    public static string DisplayGermanExchangeStudents(string studentA
        , string studentB, DateTime start, float hours)
    {
        CultureInfo culture = new("de-DE");
        string str1 = string.Format(culture, "{0} and {1} have been dating since {2:d} - that's {3:0,000.00} hours", studentA, studentB, start, hours);
        return str1;
    }
}
