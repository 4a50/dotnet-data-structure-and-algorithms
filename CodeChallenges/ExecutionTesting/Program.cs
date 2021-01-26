using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {            
            //QueueWithStacks qws = new QueueWithStacks();
            //PushInts(qws.stack1);
            //PrintStack(qws.stack1);
            //PushInts(qws.stack1);
            //Console.WriteLine(qws.stack1.Top.Value);
            //qws.Enqueue(10);
            //Console.WriteLine(qws.stack1.Top.Value);
            //qws.Dequeue();
            //Console.WriteLine(qws.stack1.Top.Value);
            //PrintStack(qws.stack1);
            //PushInts(qws.stack1);
        }
        private static void PushInts(Stack<int> stack)
        {
            stack.Push(1);
            stack.Push(2);
            stack.Push(3);
            stack.Push(4);
            stack.Push(5);
        }
        private static void PrintStack(Stack<int> qws)
        {
            Console.Write("TOP ");
            while (qws.Top != null)
            {
                Console.Write($"=> {qws.Top.Value} ");
                qws.Pop();
            }
            Console.WriteLine("Bottom");
        }
    }
}
