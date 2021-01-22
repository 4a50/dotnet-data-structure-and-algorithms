using System;
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

            Stack stack = new Stack();

            stack.Push(19);
            stack.Push(18);
            stack.Push(17);
            stack.Push(16);
            Console.WriteLine($"TOP: {stack.Top.Value}");
            stack.Pop();
            stack.Pop();
            stack.Pop();
            Console.WriteLine($"TOP: {stack.Top.Value}");



        }
    }
}
