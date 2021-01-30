namespace Trees
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }


    ///<summary>
    ///Constructor for a Node
    ///Usage: Node node = new Node(7);
    /// </summary>
    /// <param name="value"></param>
    public Node(T value)
    {
      Value = value;
    }
  }
}
