namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            Console.WriteLine("Enter a number to search: ");
            int numSearch = Convert.ToInt32(Console.ReadLine());
            OrderedList objList = new OrderedList();
            objList.SearchNumbersInOrderedList(numSearch);
            Console.ReadLine();
        }
    }
}