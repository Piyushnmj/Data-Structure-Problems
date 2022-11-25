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
    public class PalindromeChecker
    {
        public bool CheckForPalindrome()
        {
            Queue<char> objQueue = new Queue<char>();

            Console.WriteLine("\nEnter a string to check for palindrome: ");
            string word = Console.ReadLine();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                objQueue.Enqueue(word[i]);
            }

            string reverse = "";

            while (objQueue.Count != 0)
            {
                reverse = reverse + objQueue.Dequeue();
            }
            if (word.Equals(reverse))
            {
                Console.WriteLine($"\n{word} is a palindrome");
                return true;
            }
            else
            {
                Console.WriteLine($"\n{word} is not a palindrome");
                return false;
            }
        }
    }
}
