namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = File.OpenText("storage.txt"))
            {
                string lineOfFile = null;
                while ((lineOfFile = reader.ReadLine()) != null)
                {
                    Console.WriteLine(lineOfFile);
                }
            }

            string toWrite = "";

            string userInput;
            do
            {
                Console.Write("Please enter a string: ");
                userInput = Console.ReadLine().Trim();
                if (userInput != "end") toWrite += userInput + "\n";
            } while (userInput != "end");


            using (StreamWriter writer = File.CreateText("storage.txt"))
            {
                writer.WriteLine(toWrite);
            }
            Console.WriteLine("File saved!");
        }
    }
}