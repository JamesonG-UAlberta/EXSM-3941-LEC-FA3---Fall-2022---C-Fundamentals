namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            DateOnly christmas = new DateOnly(2000, 12, 25);
            DateTime now = DateTime.Now;


            Console.WriteLine(now);
            Console.WriteLine($"{christmas}, {christmas.DayOfYear} days past new years. It was a {christmas.DayOfWeek}. {christmas.DayNumber} days AD.");
            Console.WriteLine(DateTime.Parse(christmas.ToString()));

            TimeSpan mySpan = new TimeSpan(10, 5, 30, 15);
            Console.WriteLine(now.Add(mySpan));
        }
    }
}