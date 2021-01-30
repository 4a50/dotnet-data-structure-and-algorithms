using System.Collections.Generic;

namespace Trees
{
  class BinaryTree<T>
  {
    BinarySearchTree<T> bst = new BinarySearchTree<T>();
    public T[] PreOrder(Node<T> currentNode)
    {
      List<T> nodeValues = new List<T>();
      if (currentNode == null)
      {
        T[] returnArray = nodeValues.ToArray();
        return returnArray;
      }
      nodeValues.Add(currentNode.Value);

      if (currentNode.Left != null) { PreOrder(currentNode.Left); }
      if (currentNode.Right != null) { PreOrder(currentNode.Right); }

      return null;
    }
    public T[] InOrder(Node<T> currentNode)
    {
      List<T> nodeValues = new List<T>();
      if (currentNode == null)
      {
        T[] returnArray = nodeValues.ToArray();
        return returnArray;
      }
      nodeValues.Add(currentNode.Value);
      {
        if (currentNode.Left != null) { PreOrder(currentNode.Left); }
        if (currentNode.Right != null) { PreOrder(currentNode.Right); }
      }
      return null;
    }
    public T[] WalkThisWay()
    {
      T[] randoArray = new T[0];

      return randoArray;

    }

  }
}

