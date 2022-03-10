using System;
using System.Collections.Generic;
using System.Linq;
public enum Schedule
{
    Teenth,
    First,
    Second,
    Third,
    Fourth,
    Last
}

public class Meetup
{
    public int month;
    public int year;
    public Meetup(int month, int year)
    {
        this.month = month;
        this.year = year;
    }
    public DateTime Day(DayOfWeek dayOfWeek, Schedule schedule)
    {
        var dia = new DateTime(year, month, 1);
        switch (schedule)
        {
            case Schedule.First:
                for (int i = 1; i <= 7; i++)
                {
                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        return dia;
                }
                return dia;
            case Schedule.Teenth:
                List<DateTime> list1 = new();
                for (int i = 10; i <= 19; i++)
                {

                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        list1.Add(dia);

                    return list1.Last();
                }
                return dia;
            case Schedule.Second:
                for (int i = 8; i <= 14; i++)
                {
                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        return dia;
                }
                return dia;
            case Schedule.Third:
                for (int i = 15; i <= 21; i++)
                {
                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        return dia;
                }
                return dia;
            case Schedule.Fourth:
                for (int i = 22; i <= 28; i++)
                {
                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        return dia;
                }
                return dia;
            case Schedule.Last:
                List<DateTime> list = new();
                for (int i = 1; i <= DateTime.DaysInMonth(year, month); i++)
                {
                    dia = new DateTime(year, month, i);

                    if (dia.DayOfWeek == dayOfWeek)
                        list.Add(dia);
                }
                return list.Last();
            default:
                return dia;
        }
    }
}