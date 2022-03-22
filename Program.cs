using System;
using System.Linq;
using exercism.src.classes;
public class Program
{
    public static void Main()
    {
        WeighingMachine cavalo = new(precision: 3);
        cavalo.Weight = 60.5;
        Console.WriteLine(cavalo.TareAdjustment);
        cavalo.TareAdjustment = 10;
        Console.WriteLine(cavalo.TareAdjustment);
        cavalo.Weight = 60.567;
        Console.WriteLine(cavalo.DisplayWeight);

    }
}