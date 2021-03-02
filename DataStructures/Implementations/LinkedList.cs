using System;

namespace DataStructures
{
  public class LinkedList<T>
  {

    public Node<T> Head { get; set; }
    ///<summary>
    ///Empty Linked List
    ///Usage: LinkedList my List = new LinkedList();
    /// </summary>
    public LinkedList() { }
    ///<summary>
    ///Creates a linked list with a node, assigning a Head
    ///Usage: LinkedList myList = new LinkedList(4);
    /// </summary>
    /// <param name="value"></param>
    public LinkedList(T value)
    {
      Node<T> node = new Node<T>(value);
      Head = node;
    }

    //Methods

    //1st Method - While
    public string Print()
    {
      string output = "";
      Node<T> current = Head;
      while (current != null)
      {
        Console.Write($"<{current.Value}> => ");
        output += $"<{current.Value}> => ";
        current = current.Next;
      }
      Console.WriteLine("Null");
      output += "Null";
      return output;
    }

    //2nd Method - Recursive
    public string PrintR(Node<int> node)
    {
      string output = "";
      if (node == null)
      {
        Console.WriteLine("Null");
        output += "Null";
        return output;
      }
      Console.Write($"[{node.Value}] => ");
      output += $"[{node.Value}] => ";
      PrintR(node.Next);
      return output;
    }

    public void Insert(T value)
    {
      Node<T> node = new Node<T>(value);
      node.Next = Head;
      Head = node;
    }
    public bool Includes(T value)
    {
      Node<T> currentNode = Head;
      while (currentNode.Next != null)
      {
        Console.WriteLine($"Includes Object Comparison: {Object.Equals(currentNode.Value, value)}");
        //if (currentNode.Value.CompareTo == value) { return true; }
        if (Object.Equals(currentNode.Value, value)) return true;
        currentNode = currentNode.Next;
      }
      return false;
    }
    public T Append(T value)
    {
      Node<T> currentNode = Head;
      while (currentNode != null)
      {
        if (currentNode.Next == null)
        {
          Node<T> newNode = new Node<T>(value);
          currentNode.Next = newNode;
          return newNode.Value;
        }
        currentNode = currentNode.Next;
      }
      return currentNode.Value;

    }

    public T InsertAfter(T value, T newValue)
    {
      Node<T> currentNode = Head;
      while (currentNode.Next != null)
      {
        //if (currentNode.Value == value)
        if (Object.Equals(currentNode.Value, value))
        {
          Node<T> newNode = new Node<T>(newValue);
          newNode.Next = currentNode.Next;
          currentNode.Next = newNode;
          return newNode.Next.Value;
        }
        currentNode = currentNode.Next;
      }
      return default(T); //returns a null for the datatype that is used.
    }
    public T InsertBefore(T value, T newValue)
    {
      Node<T> oldNode = null;
      Node<T> currentNode = Head;
      while (currentNode.Next != null)
      {
        if (Object.Equals(currentNode.Value, value))
        //if (currentNode.Value == value)
        {
          Console.WriteLine($"Found {currentNode.Value}");
          Node<T> newNode = new Node<T>(newValue);
          oldNode.Next = newNode;
          newNode.Next = currentNode;
          return newNode.Next.Value;
        }
        oldNode = currentNode;
        currentNode = currentNode.Next;
      }
      return default(T);
    }
    /// <summary>
    /// Will locate the value of the 
    /// </summary>
    /// <param name="k"></param>
    /// <returns></returns>
    public T LocateKthNodeFromTail(int k)
    {
      Node<T> currentNode = Head;
      // Set the lengthList to one, to take into account the initial setting
      // of the Head as the currentNode
      int lengthList = 1;
      int counter = 0;
      int placeOfNode;
      T selectedNodeValue;
      //If user enters a value that is less than 0
      if (k < 0) { throw new Exception("K is less than 0"); }
      //While loop gets the length of the list and stores into lengthList
      while (currentNode.Next != null)
      {
        lengthList++;
        currentNode = currentNode.Next;
      }
      placeOfNode = lengthList - k;
      // if the position of the desire node is outside the length of the list.
      if (placeOfNode < 0) { throw new Exception("K is outside the length of the list"); }
      // if the place of Node at the zero position, return the HeadValue.
      currentNode = Head;
      if (placeOfNode == 0) { return currentNode.Value; }
      //while loop will iterate to the desired place of the node.
      do
      {
        counter++;
        selectedNodeValue = currentNode.Value;
        //Console.WriteLine($"==> {selectedNodeValue} {counter} {placeOfNode}");
        if (counter == placeOfNode) return selectedNodeValue;
        currentNode = currentNode.Next;
      } while (currentNode != null);
      return selectedNodeValue;

    }
    public static Node<T> ZipLists(LinkedList<T> aList, LinkedList<T> bList)
    {
      Node<T> a = aList.Head;
      Node<T> b = bList.Head;
      Node<T> c = b.Next;

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
