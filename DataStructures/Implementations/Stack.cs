namespace DataStructures
{
  public class Stack<T>
  {
    public Node<T> Top { get; set; }
    /// <summary>
    /// Add a node to a stack
    /// </summary>
    /// <param name="value"></param>
    public void Push(T value)
    {
      Node<T> newNode = new Node<T>(value);
      newNode.Next = Top;
      Top = newNode;
    }
    /// <summary>
    /// Remove most recent node from the stack.  
    /// </summary>
    public void Pop()
    {
      Node<T> tempNode = Top.Next;
      Top = tempNode;
    }
    /// <summary>
    /// Output the value of the node on top of the Stack.  If empty NullReference Exception
    /// will be raised.
    /// </summary>
    /// <returns></returns>
    public T Peek()
    {
      return Top.Value;
    }
    /// <summary>
    /// Return a boolean on the current state of the stack.
    /// </summary>
    /// <returns></returns>
    public bool IsEmpty()
    {
      if (Top != null) return false;
      return true;
    }
  }
}
