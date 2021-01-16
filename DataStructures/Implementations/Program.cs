using System;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(3);
            myList.Insert(34);
            myList.Insert(62);
            myList.Insert(49);
            

            myList.Print();
            myList.PrintR(myList.Head);
        }
    }
}
