using System.Collections.Generic;

namespace Trees
{
  public class BinaryTree<T>
  {
    public Node<T> Root { get; set; }

    public BinaryTree (T value)
    {
      Root = new Node<T>(value);
    }
    public T[] PreOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null)
      {
        T[] returnArray = nodeValues.ToArray();
        return returnArray;
      }
      nodeValues.Add(currentNode.Value);

      if (currentNode.Left != null) { PreOrder(currentNode.Left, nodeValues); }
      if (currentNode.Right != null) { PreOrder(currentNode.Right, nodeValues); }

      return null;
    }
    public T[] InOrder(Node<T> currentNode)
    {
      List<T> nodeValues = new List<T>();
      if (currentNode == null)
      {
        return nodeValues.ToArray();
      }
      if (currentNode.Left != null) { PreOrder(currentNode.Left, nodeValues); }
      nodeValues.Add(currentNode.Value);
      if (currentNode.Right != null) { PreOrder(currentNode.Right, nodeValues); }

      return ;

    }
    public T[] PostOrder(Node<T> currentNode)
    {
      List<T> nodeValues = new List<T>();
      if (currentNode == null)
      {
        T[] returnArray = nodeValues.ToArray();
        return returnArray;
      }
      if (currentNode.Left != null) { PreOrder(currentNode.Left, nodeValues); }
      if (currentNode.Right != null) { PreOrder(currentNode.Right, nodeValues); }
      nodeValues.Add(currentNode.Value);

      return null;

    }

  }
}

