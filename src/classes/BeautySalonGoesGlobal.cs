using System;
using System.Globalization;


public enum Location
{
    NewYork,
    London,
    Paris
}

public enum AlertLevel
{
    Early,
    Standard,
    Late
}

public static class Appointment
{
    public static DateTime ShowLocalTime(DateTime dtUtc)
    {
        return dtUtc.ToUniversalTime();
    }

    public static DateTime Schedule(string appointmentDateDescription, Location location)

    {
        DateTime date = DateTime.Parse(appointmentDateDescription);

        return location switch
        {
            Location.NewYork => TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time")),
            Location.London => TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time")),
            Location.Paris => TimeZoneInfo.ConvertTimeToUtc(date, TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time")),
            _ => DateTime.Parse(appointmentDateDescription).ToUniversalTime()
        };
    }

    public static DateTime GetAlertTime(DateTime appointment, AlertLevel alertLevel)
    {
        return alertLevel switch
        {
            AlertLevel.Early => appointment.AddDays(-1),
            AlertLevel.Late => appointment.AddMinutes(-30),
            AlertLevel.Standard => appointment.AddHours(-1).AddMinutes(-45),
            _ => appointment
        };
    }

    public static bool HasDaylightSavingChanged(DateTime dt, Location location)
    {
        TimeZoneInfo timezone = location switch
        {
            Location.NewYork => TimeZoneInfo.FindSystemTimeZoneById("Eastern Standard Time"),
            Location.Paris => TimeZoneInfo.FindSystemTimeZoneById("W. Europe Standard Time"),
            Location.London => TimeZoneInfo.FindSystemTimeZoneById("GMT Standard Time"),
            _ => throw new ArgumentException(),
        };

        if (timezone.IsDaylightSavingTime(dt.AddDays(-7)) == true && timezone.IsDaylightSavingTime(dt) == true)
            return false;
        else if (timezone.IsDaylightSavingTime(dt.AddDays(-7)) == false && timezone.IsDaylightSavingTime(dt) == false)
            return false;
        else
            return true;


    }

    public static DateTime NormalizeDateTime(string dtStr, Location location)
    {
        CultureInfo culture = location switch
        {
            Location.NewYork => new("en-US"),
            Location.Paris => new("fr-FR"),
            Location.London => new("en-GB"),
            _ => throw new ArgumentException(),
        };
        try
        {
            DateTime date = DateTime.Parse(dtStr, culture);
            return date;
        }
        catch (System.Exception)
        {
            return new DateTime(1, 1, 1);
        }

    }
}
