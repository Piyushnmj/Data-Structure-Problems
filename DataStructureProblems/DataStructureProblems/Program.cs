namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            Console.WriteLine("\nEnter a number to search: ");
            string numSearch = Console.ReadLine();
            HashTableNumberSlot objTable = new HashTableNumberSlot();
            Console.WriteLine("\n==========Before Operation==========");
            objTable.SearchNumbersInHashTable(numSearch);
            Console.WriteLine("\n==========After Operation==========");
            objTable.Display();
            Console.ReadLine();
        }
    }
}