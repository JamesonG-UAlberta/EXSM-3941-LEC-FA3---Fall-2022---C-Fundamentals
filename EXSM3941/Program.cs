namespace EXSM3941
{
    internal class Program
    {
        static void Main(string[] args)
        // The start of Main() is the entry point of the program. Execution starts here when we run the program.
        {
            Console.Write("Please enter a first word: ");
            string myString = Console.ReadLine().Trim().ToUpper();
            Console.Write("Please enter a number: ");
            // If we declare the int inside the try block, C# thinks it MIGHT not exist for the outputs (if there's an exception) so it won't let it compile.
            // Declaring it before the try block with a default value allows the outputs to work even if the user enters garbage.
            int myInt = 0;
            try
            {
                myInt = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }


        Console.WriteLine("You entered this:");
            // Concatenation (Requires string.Format for formatting)
            Console.WriteLine(myString+" "+string.Format("{0:C2}",myInt));
            // Parameterized Output (Supports Nice Formatting)
            Console.WriteLine("{0} {1:C2}", myString, myInt);
            // String Interpolation (Supports Nice Formatting)
            Console.WriteLine($"{myString} {myInt:C2}");

            // The end of Main() is the exit point of the program. The program ends naturally when we get here.
        }
    }
}