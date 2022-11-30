namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            // This is more efficient just because we aren't starting and stopping a file stream 100 times, we're sending it all at once.
            string toWrite = "";
            for (int i = 1; i <= 100; i++)
            {
                toWrite += (i + "\n");
            }

            using (StreamWriter writer = File.CreateText("storage.txt"))
            {
                writer.WriteLine(toWrite);
            }
            Console.WriteLine("File saved!");
        }
    }
}