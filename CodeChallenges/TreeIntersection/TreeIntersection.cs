using System;
using System.Collections.Generic;
using Trees;


namespace DataStructures
{
  public class TreeIntersection
  {
    public HashTable Map { get; set; }
    
    public BinaryTree<int>  TreeOne { get; set; }
    public BinaryTree<int>  TreeTwo { get; set; }    
    public Queue<Node<int>> QOne { get; set; }
    private Queue<Node<int>> QTwo { get; set; }
    public TreeIntersection()
    {
    }
    public TreeIntersection(BinaryTree<int> tOne, BinaryTree<int> tTwo) 
    {
      TreeOne = tOne;
      TreeTwo = tTwo;
    }

    //Breadth First Traversal

    public List<int> TreeIntersectValues()
    {
      List<int> dupValues = new List<int>();
      QOne = new Queue<Node<int>>();
      QTwo = new Queue<Node<int>>();
      Node<int> curNodeOne = TreeOne.Root;
      Node<int> curNodeTwo = TreeTwo.Root;
      QOne.Enqueue(curNodeOne);
      QTwo.Enqueue(curNodeTwo);
      while(QOne.Front != null || QTwo.Front != null)
      {
        curNodeOne = QOne.Front.Value;
        curNodeTwo = QTwo.Front.Value;
        if (curNodeOne.Value == curNodeTwo.Value) dupValues.Add(curNodeOne.Value);
        ShiftQueue(QOne);
        ShiftQueue(QTwo);                
      }
      return dupValues;
    }
    public void ShiftQueue(Queue<Node<int>> q)
    {
      if (q.Front == null) return;
        if (q.Front.Value.Left != null) q.Enqueue(q.Front.Value.Left);
      if (q.Front.Value.Right != null) q.Enqueue(q.Front.Value.Right);
      q.Dequeue();
    }
  
  }
}
