using Newtonsoft.Json;
using System.Collections;

namespace DataStructureProblems
{
    public class HashTableNumberSlot
    {
        public string FilePath = @"F:\Bridgelabz Codin\Data-Structure-Problems\DataStructureProblems\DataStructureProblems\NumberFile.json";

        Hashtable objHashtable = new Hashtable();

        public void SearchNumbersInHashTable(string value)
        {
            bool dataExists = false;
            string numToRead = File.ReadAllText(FilePath);
            string numData = JsonConvert.DeserializeObject<string>(numToRead);

            string[] numList = numData.Split(' ');

            for (int i = 0; i< numList.Length; i++)
            {
                objHashtable.Add(i, numList[i]);
            }

            Display();

            foreach (var key in objHashtable.Keys)
            {
                if (objHashtable[key].Equals(value))
                {
                    dataExists = true;
                    Console.WriteLine($"{objHashtable[key]} exists");
                    Console.WriteLine($"{objHashtable[key]} removed");
                    objHashtable.Remove(key);
                    Console.WriteLine();
                    break;
                }
            }
            if (!dataExists)
            {
                Console.WriteLine($"{value} does not exist");
                int addKey = objHashtable.Count + 1;
                objHashtable.Add(addKey, value);
                Console.WriteLine($"{value} added");
            }

            string[] joinString= new string[objHashtable.Count];
            int j = 0;
            foreach (var key in objHashtable.Keys)
            {
                string result = Convert.ToString(objHashtable[key]);
                joinString[j] = result;
                j++;
            }

            string combinedString = string.Join(" ", joinString);
            string numToAdd = JsonConvert.SerializeObject(combinedString);
            File.WriteAllText(FilePath, numToAdd);
        }

        public void Display()
        {
            Console.WriteLine("\nElements in Hashtable are: ");
            foreach (var key in objHashtable.Keys)
            {
                Console.WriteLine($"Slot-{key} contains number {objHashtable[key]}");
            }
        }
    }
}
