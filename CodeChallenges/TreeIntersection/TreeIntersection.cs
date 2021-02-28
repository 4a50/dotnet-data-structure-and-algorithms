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
    private Queue<Node<int>> QOne { get; set; }
    private Queue<Node<int>> QTwo { get; set; }
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
      while(curNodeOne != null || curNodeTwo != null)
      {
        curNodeOne = QOne.Front.Value;
        curNodeTwo = QTwo.Front.Value;
        if (curNodeOne.Value == curNodeTwo.Value) dupValues.Add(curNodeOne.Value);
        ShiftQueue(QOne);
        ShiftQueue(QTwo);                
      }
      return dupValues;
    }
    private void ShiftQueue(Queue<Node<int>> q)
    {
      if (q.Front.Left.Value != null) q.Enqueue(q.Front.Left.Value);
      if (q.Front.Right.Value != null) q.Enqueue(q.Front.Right.Value);
      q.Dequeue();
    }
  
  }
}
