using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructureProblems
{
    public class LinkedList<T>
    {
        public Node<T> head;

        public void Add(T data)
        {
            Node<T> objNode = new Node<T>(data);
            if (this.head == null)
            {
                this.head = objNode;
            }
            else
            {
                Node<T> temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = objNode;
            }
        }

        public void Delete(T value)
        {
            if (head == null)
            {
                return;
            }

            if (head.data.Equals(value))
            {
                head = head.next;
                return;
            }

            Node<T> temp = head;
            while (temp.next != null)
            {
                if (temp.next.data.Equals(value))
                {
                    temp.next = temp.next.next;
                    return;
                }
                temp = temp.next;
            }
        }
    }
}
