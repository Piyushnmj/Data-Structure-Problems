using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DataStructureProblems
{
    public class LinkedList
    {
        public Node head;

        public int Add(int data)
        {
            Node objNode = new Node(data);
            if (head == null)
            {
                head = objNode;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objNode;
            }
            return data;
        }

        public int Search(int value)
        {
            int count = 1;
            Node temp = head;
            while (temp != null)
            {
                if (temp.data == value)
                {
                    return count;
                }
                temp = temp.next;
                count++;
            }
            return 0;
        }

        public void Delete(int position)
        {
            if (head == null)
            {
                return;
            }
            Node temp = head;
            if (position == 1)
            {
                head = temp.next;
                return;
            }
            for (int i = 1; temp != null && i < position - 1; i++)
            {
                temp = temp.next;
            }
            if (temp == null || temp.next == null)
            {
                return;
            }
            Node next1 = temp.next.next;
            temp.next = next1;
        }

        public void Sort()
        {
            Node temp = head, index = null;

            if (head == null)
            {
                return;
            }
            else
            {
                while (temp != null)
                {
                    index = temp.next;

                    while (index != null)
                    {
                        if (temp.data > index.data)
                        {
                            int data = temp.data;
                            temp.data = index.data;
                            index.data = data;
                        }
                        index = index.next;
                    }
                    temp = temp.next;
                }
            }
        }

        public void Display(ref int size)
        {
            int i = 1;
            Node temp = head;

            if (temp == null)
            {
                Console.WriteLine("\nLinkedList is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"\nElement {i} in Linked List is: {temp.data}");
                temp = temp.next;
                size++;
                i++;
            }
        }
    }
}
