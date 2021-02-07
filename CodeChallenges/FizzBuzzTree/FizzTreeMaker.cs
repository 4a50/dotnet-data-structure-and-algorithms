using System;

namespace FizzBuzzTree
{
  public static class FizzTreeMaker
  {
    static public KAryTree<string> FizzBuzzTree(KAryTree<int> intTree)
    {
      intTree.FizzTree = new KAryTree<string>();
      intTree.FizzTree.Root = FizzBuzzIterate(intTree.Root, intTree.FizzTree.Root);
      return intTree.FizzTree;
    }
    private static KAryNode<string> FizzBuzzIterate(KAryNode<int> intNode, KAryNode<string> strNode)
    {      
      strNode.Value = FizzBuzzConverter(intNode).Value;           

      for (int i = 0; i < intNode.Leaves.Count; i++)
      {        
        strNode.Leaves.Add(new KAryNode<string>());
        FizzBuzzIterate(intNode.Leaves[i], strNode.Leaves[i]);
      }
      return strNode;
    }
    private static KAryNode<string> FizzBuzzConverter(KAryNode<int> intNode)
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