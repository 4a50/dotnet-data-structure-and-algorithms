namespace DataStructures
{
  public class Node<T>
  {
    public T Value { get; set; }
    public Node<T> Next { get; set; }
    public Node<T> Left { get; set; }
    public Node<T> Right { get; set; }

    public Node() { }

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
