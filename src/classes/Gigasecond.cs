namespace exercism.src.classes
{
    public class Gigasecond
    {
        public static DateTime Add(DateTime moment)
        {
            return moment + TimeSpan.FromSeconds(Math.Pow(10, 9));
        }

    }
}