namespace Trees
{
  public class BinarySearchTree
  {
    public Node<int> Root { get; set; }
    public BinarySearchTree() { }    
    public BinarySearchTree(int value)
    {
      Root = new Node<int>(value);
    }
    public void Add(int value)
    {
      Node<int> newNode = new Node<int>(value);
      Node<int> curNode = Root;

      if (curNode.Value < newNode.Value && curNode.Right == null) curNode.Right = newNode;
      else if (curNode.Value > newNode.Value && curNode.Left == null) curNode.Left = newNode;

      while (curNode != null)
      {
        if (newNode.Value > curNode.Value) {
          if (curNode.Right == null) curNode.Right = newNode;
          curNode = curNode.Right;
        }
        else if (newNode.Value < curNode.Value) {
          if (curNode.Left == null) curNode.Left = newNode;
          curNode = curNode.Left;
        }
        else {
          curNode = curNode.Left;
        }
      }
    }


    public bool Contains(int value)
    {
      return false;
    }
  }
}
