namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            string[] firstNames = new string[10];
            string[] lastNames = new string[10];
            int logicalSize = 0;

            Console.Write("Please enter a first and last name: ");
            string[] split = Console.ReadLine().Trim().Split(' ');
            firstNames[logicalSize] = split[0];
            lastNames[logicalSize] = split[1];
            logicalSize++;
        }
    }
}