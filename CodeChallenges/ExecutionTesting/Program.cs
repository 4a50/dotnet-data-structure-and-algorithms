using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            QueueWithStacks qws = new QueueWithStacks();
            Console.WriteLine(qws.stack1.Top.Value);
            qws.Enqueue(10);
            Console.WriteLine(qws.stack1.Top.Value);
            qws.Dequeue();
            Console.WriteLine(qws.stack1.Top.Value);

        }
    }
}
