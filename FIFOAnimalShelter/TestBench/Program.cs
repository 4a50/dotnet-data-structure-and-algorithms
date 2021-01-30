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

      int[] testArray = bt.PreOrder(bt.Root, new List<int>());
      System.Console.Write("ToOrder:");
      foreach (int i in testArray)
      {
        System.Console.Write($" [{i}]");

      }


    }
  }
}
