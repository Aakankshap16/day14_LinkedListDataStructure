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
            Console.WriteLine("{0} inserted into Linked List", node.Data);
        }

        public void Display()
        {
            Node temp = this.head;
            int count=0;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.Next;
                count++;
            }
            Console.WriteLine("Size of Linked List is " + count);
        }

       
         //Insertion
        public Node Insertion(int position, int Data)
      {
        if (position < 1)
            Console.WriteLine("Invalid position");
        if (position == 1)
        {
            var newNode = new Node(Data);
            newNode.Next = this.head;
            head = newNode;
        }
        else
        {
            while (position-- != 0)
            {
                if (position == 1)
                {
                    Node node = new Node(Data);
                    node.Next = this.head.Next;
                    head.Next = node;
                    break;
                }
                head = head.Next;
            }
            if (position != 1)
                Console.WriteLine("Position out of range");
        }
        return head;
       }
       

        
        //Delete First element
        public Node DeleteFirst()
        {
            if (this.head == null)
            {
                return null;
            }
            this.head = this.head.Next;
            return this.head;
        }
       //DELETE LAST NODE 
        public Node DeleteLast()
        {
            if(this.head == null)
            {
                return null;
            }

            if(head.Next == null)
            {
                return null;
            }
            Node newNode = head;
            while (newNode.Next.Next != null) 
            {
                newNode = newNode.Next;
            }

            newNode.Next= null;
            return head;
        }
       
        //SEARCH ELEMENT IN NODE
        public void SearchNode(int data)
        {
            int p = 0;
            Node temp = this.head;
            while (temp != null)
            {

                if (temp.Data.Equals(data))
                {
                    Console.WriteLine("The Node " + data + " Present in Position :" + p);

                }
                temp = temp.Next;
                p++;
            }

        }
        //INSERTION ANY WHERE
        public void InsertionAnyWhere(int position, int Data)
        {
            Node node = new Node(Data);
            int count = 0;

            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                node.Next = head;
                head = node;
                return;
                
            }
            
            else 
            {
                Node temp1 = null;
                Node temp = head;
                
                while (temp != null && count < position)
                {
                    temp1 = temp;
                    temp = temp.Next;
                    count++;
                }
                node.Next = temp1.Next;
                temp1.Next = node;
                
            }


        }

        //REMOVE ANY VALUE OF NODE
        public void Delete(int value)
        {
            Node temp = this.head;
            Node temp1 = null;

            if (temp != null && temp.Data == value) // if head value delete
            {
                this.head = temp.Next;
                Console.WriteLine("{0} deleted from Linked List", value);
                return;
            }

            // Search for the key to be deleted, keep track of the
            // previous node as we need to change 'prev->Next'
            while (temp != null && temp.Data != value)
            {
                temp1 = temp;
                temp = temp.Next;
            }

            if (temp == null)
            {
                Console.WriteLine(" Linked List is empty ");
                return;
            }

           //for deletion
            temp1.Next = temp.Next;

            Console.WriteLine("{0} deleted from Linked List", value);
        }


    }
}
