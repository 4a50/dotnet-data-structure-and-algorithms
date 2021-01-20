namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList myList = new LinkedList(3);
            myList.Insert(2);
            myList.Insert(22);
            myList.Insert(81);
            myList.Insert(1999);
            myList.Insert(741);
            myList.InsertBefore(22, 111);
            myList.Print();
            myList.PrintR(myList.Head);
        }
    }
}
