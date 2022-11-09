namespace EXSM3941
{
    internal class Program
    {
        static void Main(string[] args)
        // The start of Main() is the entry point of the program. Execution starts here when we run the program.
        {
            Console.Write("Please enter a word: ");
            // Trim the whitespace off and make it capitalized.
            string myString = Console.ReadLine().Trim().ToUpper();


            Console.WriteLine("You entered this:");
            Console.WriteLine(myString);

        // The end of Main() is the exit point of the program. The program ends naturally when we get here.
        }
    }
}