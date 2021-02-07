using FizzBuzzTree;
using System;
using System.Collections.Generic;

namespace TestBench
{
  class Program
  {
    static void Main(string[] args)
    {
      //Setup of the integer Tree

      KAryTree<int> intTree = new KAryTree<int>(15);
      
      intTree.Root.Leaves.Add(new KAryNode<int>(30));
      intTree.Root.Leaves.Add(new KAryNode<int>(90));
      intTree.Root.Leaves.Add(new KAryNode<int>(5));

      intTree.Root.Leaves[0].Leaves.Add(new KAryNode<int>(10));

      intTree.Root.Leaves[1].Leaves.Add(new KAryNode<int>(33));

      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(7));
      intTree.Root.Leaves[2].Leaves.Add(new KAryNode<int>(60));

      intTree.KAryTreeIteration(intTree.Root, intTree.ValueList);
      Console.WriteLine($"intTree Value {intTree.ValueList.Count}");
      foreach (int i in intTree.ValueList)
      {
        Console.Write($" {i} =>");
      }
      Console.WriteLine();
      ///
      KAryTree<string> fizzResult = FizzTreeMaker.FizzBuzzTree(intTree);
      ///

      List<string> val = fizzResult.KAryTreeIteration(fizzResult.Root, fizzResult.ValueList);
      Console.WriteLine($"ValueCount FizzResult: {val.Count} {val[1]}");
      foreach (string s in fizzResult.ValueList)
      {
        Console.Write($" {s} =>");
      }
      Console.ReadLine();





      //ktree.FizzTree.KAryTreeIteration(ktree.FizzTree.Root);
      //string[] evalString = fizzTree.ValueList.ToArray();
      //for (int i = 0; i < evalString.Length; i++)
      //{

      //Console.Write($"{evalString[i]} => ");
      //}
    }
  }
}
