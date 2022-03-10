using System;

class RemoteControlCar
{
    public int speed;
    public int batteryDrain;
    public int battery;
    public RemoteControlCar(int speed, int batteryDrain)
    {
        this.speed = speed;
        this.batteryDrain = batteryDrain;
        this.battery = 100;
    }

    public bool BatteryDrained()
    {
        if (this.battery - batteryDrain < 0)
            return true;
        else
            return false;
    }

    public int DistanceDriven()
    {
        return ((100 - battery) / batteryDrain) * speed;
    }

    public void Drive()
    {
        if (this.battery - batteryDrain >= 0)
            this.battery -= batteryDrain;
    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    public int distance;
    public RaceTrack(int distance)
    {
        this.distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        return (100 / car.batteryDrain) * car.speed >= distance;
    }
}
