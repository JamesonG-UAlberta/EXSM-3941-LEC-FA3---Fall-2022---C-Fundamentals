namespace EXSM3941
{
    public class Program
    {

        static void Main(string[] args)
        {
            List<string> myList = new List<string>()
            {
                "Hello, world! Test!",
                "Testing testing 123.",
                "Another string, test."
            };

            // Lists have a Count property that is updated during additions or removals, so that is faster than iterating for a Count().
            Console.WriteLine($"The number of items in the list is {myList.Count()}.");
            Console.WriteLine($"The number of items in the list greater than 15 characters is {myList.Count(x => x.Length > 15)}.");
            Console.WriteLine($"There are {(myList.Any(x => x.ToUpper().Contains("HELLO"))?"":"no ")}items that contain the word 'Hello'.");
            Console.WriteLine($"All the items do {(myList.All(x => x.ToUpper().Contains("TEST")) ? "" : "not ")}contain the word 'Test'.");
        }
    }
}