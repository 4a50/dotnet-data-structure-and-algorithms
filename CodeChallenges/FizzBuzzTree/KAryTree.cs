using System;
using System.Collections.Generic;
using System.Text;

namespace FizzBuzzTree
{
  public class KAryTree<T>
  {
    public KAryNode<T> Root { get; set; }
    public KAryTree<string> FizzTree { get; set; }
    public KAryTree() 
    {
      Root = new KAryNode<T>();
      FizzTree = new KAryTree<string>();

    }
    public KAryTree (T value)
    {
      Root = new KAryNode<T>(value);
      FizzTree = new KAryTree<string>();
     }
    
    public void FizzBuzzIterate(KAryNode<int> intNode, KAryNode<string> strNode)
    { 
      if (intNode == null) return;
      strNode = FizzBuzzConverter(intNode);
      if (intNode.Leaves.Count == 0) { return; }
      
      
      foreach(KAryNode<int> i in intNode.Leaves)
      {
        strNode.Leaves.Add(FizzBuzzConverter(i));
        FizzBuzzIterate(i, strNode);
      }

      return;
    }
      
  private KAryNode<string> FizzBuzzConverter(KAryNode<int> intNode)

    {
      KAryNode<string> kString = new KAryNode<string>();
      if (intNode.Value % 3 == 0 && intNode.Value % 5 == 0) { kString.Value = "FizzBuzz"; }
      else if (intNode.Value % 3 == 0) { kString.Value = "Fizz"; }
      else if (intNode.Value % 5 == 0) { kString.Value = "Buzz"; }
      else { kString.Value = intNode.Value.ToString(); }
      return kString;
    }
  }
}


