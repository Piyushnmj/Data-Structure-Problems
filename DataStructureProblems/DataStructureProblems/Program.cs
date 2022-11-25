namespace DataStructureProblems
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Data Structure Program");

            PalindromeChecker objCheck = new PalindromeChecker();
            objCheck.CheckForPalindrome();
            Console.ReadLine();
        }
    }
}