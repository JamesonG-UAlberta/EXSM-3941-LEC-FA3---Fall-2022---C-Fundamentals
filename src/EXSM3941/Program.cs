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

            Console.WriteLine("---");

            List<string> myFilteredList = myList.Where(x => x.Contains("Test")).ToList();
            foreach (string myString in myFilteredList) Console.WriteLine(myString);

            Console.WriteLine("---");

            List<int> myMutatedListInt = myList.Select(x => x.Length).ToList();
            foreach (int myInt in myMutatedListInt) Console.WriteLine(myInt.ToString());

            List<string> myMutatedListString = myList.Select(x => x.Substring(2, 5)).ToList();
            foreach (string myInt in myMutatedListString) Console.WriteLine(myInt.ToString());

            Console.WriteLine("---");

            foreach (string myString in myList.OrderBy(x => x[2])) Console.WriteLine(myString);
        }
    }
}