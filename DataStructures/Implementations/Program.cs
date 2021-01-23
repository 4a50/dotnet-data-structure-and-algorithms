namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            //LinkedList myList = new LinkedList(3);
            //myList.Insert(2);
            //myList.Insert(22);
            //myList.Insert(81);
            //myList.Insert(1999);
            //myList.Insert(741);
            //myList.InsertBefore(22, 111);
            //myList.Print();
            //myList.PrintR(myList.Head);

            //Stack stack = new Stack();

            //stack.Push(19);
            //stack.Push(18);
            //stack.Push(17);
            //stack.Push(16);

            Queue<int> queue = new Queue<int>();

            queue.Enqueue(5);
            queue.Enqueue(10);
            queue.Enqueue(20);
            queue.Enqueue(25);
            queue.Enqueue(30);
            System.Console.WriteLine($"Peek: {queue.Peek()} Empty: {queue.IsEmpty()}");
            queue.Dequeue();
            queue.Dequeue();
            queue.Dequeue();
            System.Console.WriteLine($"Peek: {queue.Peek()} Empty: {queue.IsEmpty()}");
            queue.Dequeue();
            queue.Dequeue();
            System.Console.WriteLine($"Empty: {queue.IsEmpty()}");




        }
    }
}
