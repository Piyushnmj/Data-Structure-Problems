using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems
{
    public class OrderedList
    {
        int size = 0;
        public string FilePath = @"F:\Bridgelabz Codin\Data-Structure-Problems\DataStructureProblems\DataStructureProblems\NumberFile.json";

        public void SearchNumbersInOrderedList(int num)
        {
            string numToRead = File.ReadAllText(FilePath);
            string numData = JsonConvert.DeserializeObject<string>(numToRead);

            string[] numList = numData.Split(' ');

            LinkedList objList = new LinkedList();

            foreach (string str in numList)
            {
                int element = Convert.ToInt32(str);
                objList.Add(element);
                objList.Sort();
            }

            if (objList.Search(num) > 0)
            {
                Console.WriteLine($"{num} exists");
                objList.Delete(objList.Search(num));
                Console.WriteLine($"{num} deleted successfully");
            }
            else
            {
                Console.WriteLine($"{num} does not exist");
                objList.Add(num);
                objList.Sort();
                Console.WriteLine($"{num} added successfully");
            }

            objList.Display(ref size);
            int[] joinString = new int[size];
            joinString[0] = objList.head.data;
            Node temp = objList.head;

            for (int i = 1; i < joinString.Length; i++)
            {
                temp = temp.next;
                joinString[i] = temp.data;
            }

            string combinedString = string.Join(" ", joinString);
            string numToAdd = JsonConvert.SerializeObject(combinedString);
            File.WriteAllText(FilePath, numToAdd);
        }
    }
}
