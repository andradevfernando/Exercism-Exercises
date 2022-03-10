namespace exercism.src.classes;
using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        return balance switch
        {
            decimal n when (n < 0) => (float)Math.Round(0.032130f * 100, 5),
            decimal n when (n < 1000 && n >= 0) => (float)Math.Round(0.005f * 100, 4),
            decimal n when (n < 5000 && n >= 1000) => (float)Math.Round(0.01621f * 100, 5),
            decimal n when (n >= 5000) => (float)Math.Round(0.02475f * 100, 5),
            _ => 0f,

        };
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) * balance / 100;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return (decimal)InterestRate(balance) * balance / 100 + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (balance < targetBalance)
        {
            years++;
            balance = (decimal)InterestRate(balance) * balance / 100 + balance;
        }
        // (int)Math.Ceiling((Math.Log10(((double)targetBalance) / (double)balance)) / Math.Log10((1 + ((double)InterestRate(balance) / 100))))
        return years;
    }
}

