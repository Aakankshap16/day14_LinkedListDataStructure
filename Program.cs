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
            list.Add(30);
            Console.WriteLine("Next Append 70 to 56");
            Console.WriteLine(" ");
            list.Add(70);
            Console.WriteLine("Finally Append 70 to 30");
            Console.WriteLine(" ");
            
            list.InsertionAnyWhere(2, 40);
            Console.WriteLine("Finally insert 40");
            Console.WriteLine(" ");
            
            Console.WriteLine("LinkedList Sequence:");
            list.Display();
            Console.WriteLine(" ");
            list.sort();
            list.Display();

        }

    }
}