namespace exercism.src.classes
{
    public class AssemblyLine
    {
        public static double SuccessRate(int speed)
        {
            return speed switch
            {
                int n when (n >= 1 && n <= 4) => 1,
                int n when (n >= 4 && n <= 8) => 0.9,
                9 => 0.8,
                10 => 0.77,
                _ => 0,
            };
        }

        public static double ProductionRatePerHour(int speed)
        {
            return 221 * speed * SuccessRate(speed);
        }

        public static int WorkingItemsPerMinute(int speed)
        {
            return (int)Math.Floor(ProductionRatePerHour(speed) / 60);
        }
    }
}