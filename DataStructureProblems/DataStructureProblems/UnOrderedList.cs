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
    public class UnOrderedList<T>
    {
        public string FilePath = @"F:\Bridgelabz Codin\Data-Structure-Problems\DataStructureProblems\DataStructureProblems\TextFile.json";

        public void SearchWord()
        {
            string textToRead = File.ReadAllText(FilePath);
            string textData = JsonConvert.DeserializeObject<string>(textToRead);

            string[] wordList = textData.Split(' ');

            Console.WriteLine("Enter a word to search: ");
            string wordSearch = Console.ReadLine();

            LinkedList<string> objList = new LinkedList<string>();

            foreach (string words in wordList)
            {
                objList.Add(words);
            }

            bool exists = false;
            foreach (string word in wordList)
            {
                if (word == wordSearch)
                {
                    exists = true;
                    Console.WriteLine($"{wordSearch} exists");
                    objList.Delete(wordSearch);
                    Console.WriteLine($"{wordSearch} removed successfully");
                    break;
                }
            }
            if (!exists)
            {
                Console.WriteLine($"{wordSearch} does not exist");
                objList.Add(wordSearch);
                Console.WriteLine($"{wordSearch} added successfully");
            }

            int size = 0;
            Node<string> temp = objList.head;
            while (temp != null)
            {
                temp = temp.next;
                size++;
            }

            string[] wordManipulate = new string[size];

            wordManipulate[0] = objList.head.data;
            Node<string> temp2 = objList.head;

            for (int i = 1; i < wordManipulate.Length; i++)
            {
                temp2 = temp2.next;
                wordManipulate[i] = temp2.data;
            }

            string combinedString = string.Join(" ", wordManipulate);
            string wordToAdd = JsonConvert.SerializeObject(combinedString);
            File.WriteAllText(FilePath, wordToAdd);
        }
    }
}
