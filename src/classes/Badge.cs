using System;

static class Badge
{
    public static string Print(int? id, string name, string? department)
    {
        string badge;
        if (id != null && department != null)
            badge = $"[{id}] - {name} - {department.ToUpper()}";
        else if (department != null)
            badge = $"{name} - {department.ToUpper()}";
        else if (id != null)
            badge = $"[{id}] - {name} - OWNER";
        else
            badge = $"{name} - OWNER";
        return badge;
    }
}
