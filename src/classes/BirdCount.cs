namespace exercism.src.classes
{
    public class BirdCount
    {
        private int[] birdsPerDay;

        public BirdCount(int[] birdsPerDay)
        {
            this.birdsPerDay = birdsPerDay;
        }

        public static int[] LastWeek()
        {
            return new[] { 0, 2, 5, 3, 7, 8, 4 };
        }

        public int Today()
        {
            return birdsPerDay[6];
        }

        public void IncrementTodaysCount()
        {
            birdsPerDay[6] += 1;
        }

        public bool HasDayWithoutBirds()
        {
            foreach (int i in birdsPerDay)
            {
                if (i == 0)
                    return true;
            };
            return false;
        }

        public int CountForFirstDays(int numberOfDays)
        {
            int sum = 0;
            for (int i = 0; i < numberOfDays; i++)
            {
                sum += birdsPerDay[i];
            }
            return sum;
        }

        public int BusyDays()
        {
            int j = 0;
            foreach (int i in birdsPerDay)
            {
                if (i >= 5)
                    j++;
            };
            return j;
        }
    }
}