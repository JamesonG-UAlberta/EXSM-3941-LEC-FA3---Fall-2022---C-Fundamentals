namespace EXSM3941
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> myList = new List<string>();
            myList.Add("Hello, world!");
            myList.Add("Test.");
            myList.Add("123");
            myList.Add("123");

            HashSet<string> myHashSet = new HashSet<string>();
            myHashSet.Add("Hello, world!");
            myHashSet.Add("Test.");
            myHashSet.Add("123");
            myHashSet.Add("123");

            SortedSet<string> mySortedSet = new SortedSet<string>();
            mySortedSet.Add("Hello, world!");
            mySortedSet.Add("Test.");
            mySortedSet.Add("123");
            mySortedSet.Add("123");

            Console.WriteLine(myList[1]);
            Console.WriteLine(myHashSet.ElementAt(1));
            Console.WriteLine(myHashSet.ToArray()[1]);
            Console.WriteLine(mySortedSet.ElementAt(1));
            Console.WriteLine(mySortedSet.ToArray()[1]);
        }
    }
}