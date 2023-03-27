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
            list.Add(30);
            list.Add(70);
            list.Display();
        }
    }
}
