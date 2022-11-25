using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class BankCashCounter
    {
        long bankBalance = 10000;

        public void Bank()
        {
            Console.WriteLine("\nEnter the banking service you want \n1. Deposit \n2. Withdraw");
            int service = Convert.ToInt32(Console.ReadLine());
            long account = 0;

            switch (service)
            {
                case 1:
                    Console.WriteLine("\nEnter amount to Deposit: ");
                    account = Convert.ToInt64(Console.ReadLine());
                    bankBalance += account;
                    break;
                case 2:
                    Console.WriteLine("\nEnter amount to Withdraw: ");
                    account = Convert.ToInt64(Console.ReadLine());
                    bankBalance -= account;
                    break;
            }
        }

        public void CashCounter()
        {
            Console.WriteLine("\nNumber of people in Queue: ");
            int people = Convert.ToInt32(Console.ReadLine());

            Queue<int> objQueue = new Queue<int>();

            for (int i = 1; i <= people; i++)
            {
                objQueue.Enqueue(i);
                Bank();
                objQueue.Dequeue();
            }
            if (objQueue.Count == 0)
            {
                Console.WriteLine("\nQueue empty");
            }
            else
            {
                Console.WriteLine("\nPeople in Queue");
            }
            Console.WriteLine($"\nCash in Bank: {bankBalance}");
        }
    }
}
