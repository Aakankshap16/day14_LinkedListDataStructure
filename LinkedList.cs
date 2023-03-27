using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListProgram
{
    public class LinkedList
    {
        public Node head;

        public void Add(int Data)
        {
            Node node = new Node(Data);
            if (this.head == null) 
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.Next != null) 
                {
                    temp = temp.Next;
                }
                temp.Next = node;
                         
            }
            Console.WriteLine($"{node.Data} inserted into linked list ");
        }

        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Linkedlist is empty");
                return;
            }
            while (temp  != null)
            {
                Console.WriteLine(temp.Data+" ");
                temp = temp.Next;
            }


        }

    }
}
