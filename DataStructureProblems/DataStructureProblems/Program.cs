namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            BankCashCounter objStack = new BankCashCounter();
            objStack.CashCounter();
            Console.ReadLine();
        }
    }
}