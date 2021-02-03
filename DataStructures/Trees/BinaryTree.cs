using System;
using System.Collections.Generic;
using DataStructures;

namespace Trees
{
  public class BinaryTree<T> where T : IComparable
  {
    public Node<T> Root { get; set; }

    public BinaryTree() { }
        
    public BinaryTree(T value)
    {
      Root = new Node<T>(value);
    }
    /// <summary>
    /// Depth First Traversal using a Pre-Order Strategy
    /// </summary>
    /// <param name="currentNode"></param>
    /// <param name="nodeValues"></param>
    /// <returns></returns>
    public T[] PreOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null)
      {
        return nodeValues.ToArray();
      }
      nodeValues.Add(currentNode.Value);
      if (currentNode.Left != null) { PreOrder(currentNode.Left, nodeValues); }
      if (currentNode.Right != null) { PreOrder(currentNode.Right, nodeValues); }

      return nodeValues.ToArray();
    }
    /// <summary>
    /// Depth First Traversal using a In-Order Strategy
    /// </summary>
    /// <param name="currentNode"></param>
    /// <param name="nodeValues"></param>
    /// <returns></returns>
    public T[] InOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null) return nodeValues.ToArray();

      if (currentNode.Left != null) InOrder(currentNode.Left, nodeValues);
      nodeValues.Add(currentNode.Value);
      if (currentNode.Right != null) InOrder(currentNode.Right, nodeValues);
      return nodeValues.ToArray();
    }
    /// <summary>
    /// Depth First Traversal using a Post-Order Strategy
    /// </summary>
    /// <param name="currentNode"></param>
    /// <param name="nodeValues"></param>
    /// <returns></returns>
    public T[] PostOrder(Node<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null) return nodeValues.ToArray();

      if (currentNode.Left != null) PostOrder(currentNode.Left, nodeValues);
      if (currentNode.Right != null) PostOrder(currentNode.Right, nodeValues);
      nodeValues.Add(currentNode.Value);
      return nodeValues.ToArray();
    }
    public T FindMax(T maxValue, Node<T> curNode)
    {      
      if (curNode == null) return maxValue;
      Console.WriteLine($"curNode: {curNode.Value}\tmaxValue: {maxValue}\tCompare: {maxValue.CompareTo(curNode.Value)}");
      if (maxValue.CompareTo(curNode.Value) < 0) maxValue = curNode.Value;
      

      if (curNode.Left != null) FindMax(maxValue, curNode.Left);
      if (curNode != null) FindMax(maxValue, curNode.Right);
      return maxValue;
    }
    /// <summary>
    /// Traverses the Binary Tree using a Breadth First Strategy
    /// </summary>
    /// <returns></returns>
    public List<T> TraverseBreadth()
    {
      DataStructures.Queue<Node<T>> nodeQueue = new DataStructures.Queue<Node<T>>();

      List<T> nodeList = new List<T>();
      nodeQueue.Enqueue(Root);
      Node<T> curNode = new Node<T>();

      while (!nodeQueue.IsEmpty())
      {
        //TODO: Catch the null before you try to assign it to curNode
        
                  curNode = nodeQueue.Dequeue().Value;
        

        if (curNode != null) nodeList.Add(curNode.Value);
        if (curNode.Left != null) nodeQueue.Enqueue(curNode.Left);
        if (curNode.Right != null) nodeQueue.Enqueue(curNode.Right);
      }
      return nodeList;
}


  }
}

