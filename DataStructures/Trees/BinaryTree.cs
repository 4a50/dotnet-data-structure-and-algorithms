using System;
using System.Collections.Generic;

namespace Trees
{
  public class BinaryTree<T> where T : IComparable
  {
    public TreeNode<T> Root { get; set; }

    public BinaryTree() { }
        
    public BinaryTree(T value)
    {
      Root = new TreeNode<T>(value);
    }
    /// <summary>
    /// Depth First Traversal using a Pre-Order Strategy
    /// </summary>
    /// <param name="currentNode"></param>
    /// <param name="nodeValues"></param>
    /// <returns></returns>
    public T[] PreOrder(TreeNode<T> currentNode, List<T> nodeValues)
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
    public T[] InOrder(TreeNode<T> currentNode, List<T> nodeValues)
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
    public T[] PostOrder(TreeNode<T> currentNode, List<T> nodeValues)
    {
      if (currentNode == null) return nodeValues.ToArray();

      if (currentNode.Left != null) PostOrder(currentNode.Left, nodeValues);
      if (currentNode.Right != null) PostOrder(currentNode.Right, nodeValues);
      nodeValues.Add(currentNode.Value);
      return nodeValues.ToArray();
    }
    public T FindMax(T maxValue, TreeNode<T> curNode)
    {      
      if (curNode == null) return maxValue;
      Console.WriteLine($"curNode: {curNode.Value}\tmaxValue: {maxValue}\tCompare: {maxValue.CompareTo(curNode.Value)}");
      if (maxValue.CompareTo(curNode.Value) < 0) maxValue = curNode.Value;
      

      if (curNode.Left != null) FindMax(maxValue, curNode.Left);
      if (curNode != null) FindMax(maxValue, curNode.Right);
      return maxValue;
    }    

    
  }
}

