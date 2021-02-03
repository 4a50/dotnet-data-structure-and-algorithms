namespace DataStructures
{
  public class Queue<T>
  {
    public Node<T> Front { get; set; }
    public Node<T> Rear { get; set; }


    public void Enqueue(T value)
    {
      Node<T> newNode = new Node<T>(value);
      if (Front == null) { Front = newNode; Rear = newNode; }
      Rear.Next = newNode;
      Rear = newNode;
    }

    public Node<T> Dequeue()
    {
      Node<T> tempNode = Front.Next;
      Front = tempNode;
      return tempNode;
    }
    public bool Peek()
    {
      if (Front == null) return false;
      return true;
    }

    public bool IsEmpty()
    {
      if (Front != null) return false;
      return true;
    }

  }

}
