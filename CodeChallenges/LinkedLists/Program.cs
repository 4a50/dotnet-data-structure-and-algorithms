using System;

namespace DataStructures
{
  public class Program
  {
    static void Main(string[] args)
    {
      LinkedList<int> aList = new LinkedList<int>();
      aList.Insert(10);
      aList.Insert(8);
      aList.Insert(6);
      aList.Insert(4);
      aList.Insert(2);
      LinkedList<int> bList = new LinkedList<int>();
      bList.Insert(9);
      bList.Insert(7);
      bList.Insert(5);
      bList.Insert(3);
      bList.Insert(1);

      Console.WriteLine("A List");
      aList.Print();
      Console.WriteLine("B List");
      bList.Print();
      Console.WriteLine(ZipLists(aList, bList).Value);
      aList.Print();
    }
    public static Node<int> ZipLists(LinkedList<int> aList, LinkedList<int> bList)
    {
      Node<int> a = aList.Head;
      Node<int> b = bList.Head;
      Node<int> c = b.Next;

      while (b.Next != null)
      {
        //Connect Node A to B, B next to a.Next to start the zip process
        b.Next = a.Next;
        a.Next = b;
        //Move our pointers one increment.
        a = b.Next;
        b = c;
        c = c.Next;

      }
      //The loop will exit before the last node is connected.  This must be in to complete the list.
      a.Next = b;
      return a.Next;
    }
  }
}
