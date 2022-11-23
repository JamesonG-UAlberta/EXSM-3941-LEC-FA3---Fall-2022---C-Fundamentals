namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Initialize arrays with a length, which will fill them with the default value.
            List<string> myList = new List<string>();
            List<int> myIntList = new List<int>();

            List<bool> myBoolList = new List<bool>() { true, false, false, true, false };


            List<string> userEntries = new List<string>();
            // Start off with an "empty" array.
            string userChoice = "";
            do

            {
                Console.WriteLine("1. Add\n2. Clear\n3. View\n4. Exit");
                Console.Write("Choose: ");
                userChoice = Console.ReadLine().Trim();
                switch (userChoice)
                {
                    case "1":
                        Console.Write("Enter what you'd like to add: ");
                        // Set the "next" entry to what they enter.
                        userEntries.Add(Console.ReadLine().Trim());
                        break;
                    case "2":
                        userEntries.Clear();
                        break;
                    case "3":
                        foreach (string item in userEntries)
                        {
                            Console.WriteLine(item);
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