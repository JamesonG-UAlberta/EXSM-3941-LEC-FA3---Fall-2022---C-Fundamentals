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

            // Cannot contain duplicate items. If you try, it will ignore the add.
            HashSet<string> myHashSet = new HashSet<string>();
            myHashSet.Add("Hello, world!");
            myHashSet.Add("Test.");
            myHashSet.Add("123");
            myHashSet.Add("123");

            // Cannot contain duplicate items, like above, but also sorts by default.
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



            Stack<string> myStack = new Stack<string>();
            Queue<string> myQueue = new Queue<string>();

            // Adding
            myStack.Push("A new box.");
            myQueue.Enqueue("A person in line.");

            // Looking
            myStack.Peek(); // "A new box."
            myQueue.Peek(); // "A person in line."

            // Processing
            myStack.Pop(); // "A new box."
            myQueue.Dequeue(); // "A person in line."



            Dictionary<string, string> myDictionary = new Dictionary<string, string>();
            myDictionary.Add("Walk", "To locomote by way of legs.");
            myDictionary.Add("See", "To visually observe.");
            myDictionary.Add("Talk", "To make a noise with intentions of communication.");

            // Bracketed indexing defaults to searching by Key.
            Console.WriteLine(myDictionary["See"]);

            // You can iterate normally through ".Keys" or ".Values", or use a KeyValuePair to use both at once.
            foreach(KeyValuePair<string, string> kvp in myDictionary)
            {
                Console.WriteLine($"{kvp.Key}: {kvp.Value}");
            }

            // Pulling a KVP by index.
            Console.WriteLine(myDictionary.ElementAt(1));

            // SortedDictionary always sorts by the Key. SortedList defaults to the Key but the behaviour can be customized.
            SortedList<string, string> mySortedList = new SortedList<string, string>();
            mySortedList.Add("Walk", "To locomote by way of legs.");
            mySortedList.Add("See", "To visually observe.");
            mySortedList.Add("Talk", "To make a noise with intentions of communication.");
        }
    }
}