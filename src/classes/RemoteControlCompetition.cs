using System;
using System.Collections.Generic;
using System.Linq;
public interface IRemoteControlCar
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }
    public void Drive()
    {
    }
}

public class ProductionRemoteControlCar : IRemoteControlCar, IComparable<ProductionRemoteControlCar>
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }


    public int CompareTo(ProductionRemoteControlCar? other)
    {
        return 0;
    }

    public void Drive()
    {
        DistanceTravelled += 10;
    }

}

public class ExperimentalRemoteControlCar : IRemoteControlCar
{
    public int DistanceTravelled { get; set; }
    public int NumberOfVictories { get; set; }


    public void Drive()
    {
        DistanceTravelled += 20;
    }
}

public static class TestTrack
{
    public static void Race(IRemoteControlCar car)
    {
        car.Drive();
    }

    public static List<ProductionRemoteControlCar> GetRankedCars(ProductionRemoteControlCar prc1,
        ProductionRemoteControlCar prc2)
    {
        List<ProductionRemoteControlCar> lista = new() { prc1, prc2 };
        lista = lista.OrderBy(x => x.NumberOfVictories).ToList();
        return lista;
    }
}
