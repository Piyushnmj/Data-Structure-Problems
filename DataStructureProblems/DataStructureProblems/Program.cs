namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            StackClass objStack = new StackClass();
            objStack.BalancedParenthesis();
            Console.ReadLine();
        }
    }
}