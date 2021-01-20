using System;

namespace DataStructures
{
    public class Program
    {
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();
            list.Insert(12);
            list.Insert(24);
            list.Insert(48);
            list.Insert(60);
            list.Insert(72);
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(list.LocateKthNodeFromTail(i));
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(list.LocateKthNodeFromTail(7));
            Console.WriteLine(list.LocateKthNodeFromTail(-1));
            list.Print();
            list.PrintR(list.Head);

            



        }
    }
}
