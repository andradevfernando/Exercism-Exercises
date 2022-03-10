namespace exercism.src.classes
{
    public class RemoteControlCar
    {
        public int battery;
        public int distance;
        public RemoteControlCar()
        {
            battery = 100;
            distance = 0;
        }
        public static RemoteControlCar Buy()
        {
            return new RemoteControlCar();
        }

        public string DistanceDisplay()
        {
            return $"Driven {distance} meters";
        }

        public string BatteryDisplay()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.BatteryDisplay() method");
        }

        public void Drive()
        {
            throw new NotImplementedException("Please implement the RemoteControlCar.Drive() method");
        }
    }
}