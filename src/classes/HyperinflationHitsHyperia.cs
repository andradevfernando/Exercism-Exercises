using System;

public static class CentralBank
{
    public static string DisplayDenomination(long @base, long multiplier)
    {
        try
        {
            long result = checked(@base * multiplier);
            return result.ToString();
        }
        catch (System.OverflowException)
        {
            return "*** Too Big ***";
        }
    }

    public static string DisplayGDP(float @base, float multiplier)
    {
        float result = checked(@base * multiplier);
        if (result != float.PositiveInfinity)
            return result.ToString();
        else
            return "*** Too Big ***";
    }

    public static string DisplayChiefEconomistSalary(decimal salaryBase, decimal multiplier)
    {
        try
        {
            decimal result = checked(salaryBase * multiplier);
            return result.ToString();
        }
        catch (System.OverflowException)
        {
            return "*** Much Too Big ***";
        }
    }
}
