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
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.Next;
            }
        }

        public Node Insertion(int Position, int Data)
        {
            if (Position < 1)
            {
                Console.WriteLine(" Not Possible");
            }
            else if (Position == 1)
            {
                var newNode = new Node(Data);
                newNode.Next = this.head;
                head = newNode;
            }
            else
            {
                int currentPosition = 1;
                Node temp = head;
                while (temp != null && currentPosition < Position - 1)
                {
                    temp = temp.Next;
                    currentPosition++;
                }
                if (temp == null)
                {
                    Console.WriteLine("Position out of the range.");
                }
                else
                {
                    Node newNode = new Node(Data);
                    newNode.Next = temp.Next;
                    temp.Next = newNode;
                    Console.WriteLine($"{newNode.Data} inserted at position {Position}");
                }
            }
            return head;
        }
    }

}
