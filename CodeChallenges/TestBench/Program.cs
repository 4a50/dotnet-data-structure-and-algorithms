using DataStructures;
using FizzBuzzTree;
using System;
using System.Collections.Generic;
using Trees;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      BinaryTree<int> b1 = new BinaryTree<int>(150);
      b1.Root.Left = new Node<int>(100);
      b1.Root.Left.Left = new Node<int>(75);

      b1.Root.Left.Right = new Node<int>(160);
      b1.Root.Left.Right.Left = new Node<int>(125);
      b1.Root.Left.Right.Right = new Node<int>(175);

      b1.Root.Right = new Node<int>(250);
      b1.Root.Right.Left = new Node<int>(200);

      b1.Root.Right.Right = new Node<int>(350);
      b1.Root.Right.Right.Left = new Node<int>(300);
      b1.Root.Right.Right.Right = new Node<int>(500);

      BinaryTree<int> b2 = new BinaryTree<int>(42);
      b2.Root.Left = new Node<int>(100);
      b2.Root.Left.Left = new Node<int>(15);

      b2.Root.Left.Right = new Node<int>(160);
      b2.Root.Left.Right.Left = new Node<int>(125);
      b2.Root.Left.Right.Right = new Node<int>(175);

      b2.Root.Right = new Node<int>(600);
      b2.Root.Right.Left = new Node<int>(200);

      b2.Root.Right.Right = new Node<int>(350);
      b2.Root.Right.Right.Left = new Node<int>(4);
      b2.Root.Right.Right.Right = new Node<int>(500);

      TreeIntersection treeIntersection = new TreeIntersection(b1, b2);
      List<int> testValues = treeIntersection.TreeIntersectValues();
      List<int> expectedValues = new List<int> { 100, 160, 125, 175, 200, 350, 500 };
      Console.ReadKey();
      

    }

  }
}
