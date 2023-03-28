namespace LinkedListProgram
{
    class Program
    {
       
            public static void Main(string[] args)
            {
                Console.WriteLine("Welcome to Linkedlist problem!");
                Console.WriteLine("**********************************");
                LinkedList list = new LinkedList();
                list.Add(56);
                Console.WriteLine("Node with data 56 is First Created");
                Console.WriteLine(" ");
                list.Add(70);
                Console.WriteLine("Next Append 70 to 56");
                Console.WriteLine(" ");
            list.Insertion(2, 30);
            Console.WriteLine("Finally insert 30 in between 56 and 70:");
                Console.WriteLine(" ");
                Console.WriteLine("LinkedList Sequence:");
                list.Display();
           
            }
        
    }
}