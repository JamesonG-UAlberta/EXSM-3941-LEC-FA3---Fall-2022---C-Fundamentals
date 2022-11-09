namespace EXSM3941
{
    internal class Program
    {
        static void Main(string[] args)
        // The start of Main() is the entry point of the program. Execution starts here when we run the program.
        {
            Console.Write("Please enter a first word: ");
            string myString1 = Console.ReadLine().Trim().ToUpper();
            Console.Write("Please enter a second word: ");
            string myString2 = Console.ReadLine().Trim().ToUpper();

            Console.WriteLine("You entered this:");
            // Concatenation
            Console.WriteLine(myString1+" "+myString2);
            // Parameterized Output
            Console.WriteLine("{0} {1}", myString1, myString2);
            // String Interpolation
            Console.WriteLine($"{myString1} {myString2}");

            // The end of Main() is the exit point of the program. The program ends naturally when we get here.
        }
    }
}