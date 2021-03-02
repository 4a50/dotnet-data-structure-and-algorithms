using DataStructures;

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
    /// <summary>
    /// Adds a Node to a Binary Search Tree
    /// </summary>
    /// <param name="value"></param>
    public void Add(int value)
    {
      Node<int> newNode = new Node<int>(value);
      Node<int> curNode = Root;

      if (curNode.Value < newNode.Value && curNode.Right == null) curNode.Right = newNode;
      else if (curNode.Value > newNode.Value && curNode.Left == null) curNode.Left = newNode;
      else
      {
        while (curNode != null)
        {
          if (newNode.Value > curNode.Value)
          {
            if (curNode.Right == null) curNode.Right = newNode;
            curNode = curNode.Right;
          }
          else if (newNode.Value < curNode.Value)
          {
            if (curNode.Left == null) curNode.Left = newNode;
            curNode = curNode.Left;
          }
          else
          {
            curNode = curNode.Left;
          }
        }
      }
    }

    /// <summary>
    /// Searches a Binary Search Tree for a int Value
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public bool Contains(int value)
    {
      bool doesContain = false;
      Node<int> curNode = Root;
      while (curNode != null)
      {
        if (value < curNode.Value) curNode = curNode.Left;
        else if (value > curNode.Value) curNode = curNode.Right;
        else
        {
          doesContain = true;
          break;
        }
      }
      return doesContain;
    }
  }
}
