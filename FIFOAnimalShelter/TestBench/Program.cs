using FifoAnimalShelter;
using System.Collections.Generic;
using Trees;

namespace DataStuctures

{
  class Program
  {
    static void Main(string[] args)
    {
      //AnimalShelter shelter = new AnimalShelter();
      BinaryTree<int> bt = new BinaryTree<int>(756);
      System.Console.WriteLine(bt.Root.Value);
      bt.Root.Left = new Node<int>(752);
      bt.Root.Left.Left= new Node<int>(2);
      bt.Root.Left.Right = new Node<int> (743);

      bt.Root.Right = new Node<int>(705);
      bt.Root.Right.Left = new Node<int>(81);
      bt.Root.Right.Right = new Node<int>(22);
      
      System.Console.Write("PreOrder:" );      
      int[] test = bt.PreOrder(bt.Root, new List<int>());      
      foreach (int i in test) { System.Console.Write($" [{i}]"); }
      System.Console.WriteLine();

      System.Console.Write("OnOrder:");
      test = bt.InOrder(bt.Root, new List<int>());
      foreach (int i in test) { System.Console.Write($" [{i}]"); }
      System.Console.WriteLine();

      System.Console.Write("PostOrder:");
      test = bt.PostOrder(bt.Root, new List<int>());
      foreach (int i in test) { System.Console.Write($" [{i}]"); }
      System.Console.WriteLine();


    }
  }
}
