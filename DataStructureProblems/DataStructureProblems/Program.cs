namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            StackClass<char> objStack = new StackClass<char>();
            objStack.BalancedParenthesis();
            Console.ReadLine();
        }
    }
}