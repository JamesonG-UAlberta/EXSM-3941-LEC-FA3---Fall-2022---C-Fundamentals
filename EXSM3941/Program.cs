namespace EXSM3941
{
    internal class Program
    {


        // Void in this case means nothing is returned.
        static void ExampleFunction(string input, out string output)
        {
            Console.WriteLine($"Input: {input}");
            output = input.ToUpper();
        }
        static void Main(string[] args)
        // The start of Main() is the entry point of the program. Execution starts here when we run the program.
        {
            string uppercase;
            ExampleFunction("Hello!", out uppercase);

            Console.Write("Please enter a first word: ");
            string myString = Console.ReadLine().Trim().ToUpper();
            Console.Write("Please enter a number: ");
            // If we declare the int inside the try block, C# thinks it MIGHT not exist for the outputs (if there's an exception) so it won't let it compile.
            // Declaring it before the try block with a default value allows the outputs to work even if the user enters garbage.
            int myInt = 0;
            string determinedOutput = "";
            try
            {
                myInt = int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            // If side runs if the condition is true.
            if (myInt > 10)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                determinedOutput = "That's greater than 10!";
            }
            // Else side runs if the condition is false.
            // Because single-statement if and elses can be used without braces, we can stick a second if directly beside an else, to make a decision tree.
            else if (myInt < 10)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                determinedOutput = "That's less than 10!";
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                determinedOutput = "That's 10!";
            }
            Console.WriteLine(determinedOutput);
            Console.ForegroundColor = ConsoleColor.White;


            // While & For loops run 0 or more times.
            // Initialize
            int whileCount = 1;
            // Test
            while (whileCount <= myInt)
            {
                // Process
                Console.WriteLine(whileCount);
                // Modify
                whileCount++;
            }

            // Initialize; Modify; Test;
            for (int forCount = 1; forCount <= myInt; forCount++)
            {
                // Process
                Console.WriteLine(forCount);
            }

            // Do while loops run 1 or more times.
            // Initialize
            int doWhileCount = 1;
            do
            {
                // Process
                Console.WriteLine(doWhileCount);
                // Modify
                doWhileCount++;
            // Test
            } while (doWhileCount <= myInt);


            Console.WriteLine("You entered this:");
            // Concatenation (Requires string.Format for formatting)
            Console.WriteLine(myString + " " + string.Format("{0:C2}", myInt));
            // Parameterized Output (Supports Nice Formatting)
            Console.WriteLine("{0} {1:C2}", myString, myInt);
            // String Interpolation (Supports Nice Formatting)
            Console.WriteLine($"{myString} {myInt:C2}");

            // The end of Main() is the exit point of the program. The program ends naturally when we get here.
        }
    }
}