namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize arrays with a length, which will fill them with the default value.
            string[] myArray = new string[10];
            int[] myIntArray = new int[5];

            bool[] myBoolArray = new bool[] { true, false, false, true, false };


            string[] userEntries = new string[5];
            // Start off with an "empty" array.
            int userEntriesLogicalSize = 0;
            string userChoice = "";
            do

            {
                Console.WriteLine("1. Add\n2. Clear\n3. View\n4.Exit");
                Console.Write("Choose: ");
                userChoice = Console.ReadLine().Trim();
                switch(userChoice)
                {
                    case "1":
                        if (userEntriesLogicalSize >= userEntries.Length)
                        {
                            Console.WriteLine("The array is full.");
                        }
                        else
                        { 
                            Console.Write("Enter what you'd like to add: ");
                            // Set the "next" entry to what they enter.
                            userEntries[userEntriesLogicalSize] = Console.ReadLine().Trim();
                            userEntriesLogicalSize++;
                        }
                        
                        break;
                    case "2":
                        // Reset logical size to zero, which limits our output loop to not show the "garbage" data.
                        // It will be overwritten with new adds.
                        userEntriesLogicalSize = 0;
                        break;
                    case "3":
                        // Show up to the the logical size, nothing more.
                        for (int i = 0; i < userEntriesLogicalSize; i++)
                        {
                            Console.WriteLine(userEntries[i]);
                        }
                        break;
                    case "4":
                        break;
                    default:
                        Console.WriteLine("Invalid input please try again.");
                        break;
                } 

            } while (userChoice != "4");

        }
    }
}